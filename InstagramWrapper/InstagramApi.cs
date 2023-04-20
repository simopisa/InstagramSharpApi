using InstagramWrapper.Models.Feed;
using InstagramWrapper.Models.Followers;
using InstagramWrapper.Models.Following;
using InstagramWrapper.Models.Likers;
using InstagramWrapper.Models.MediaInfo;
using InstagramWrapper.Models.ProfileInfo;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace InstagramWrapper
{
    public class InstagramApi
    {
        private ProductInfoHeaderValue userAgent;
        private HttpClient httpClient;
        private const string BASE_URL = "https://www.instagram.com/api/v1/";
        private string cookies;


        /// <summary>
        /// Initialize a new instance of the <see cref="InstagramApi"/> class with a sessionId and a ds_user_id
        /// </summary>
        /// <param name="sessionId">sessionId cookie from your Instagram account</param>
        /// <param name="ds_user_id">ds_user_id cookie from your Instagram account</param>
        public InstagramApi(string sessionId, string ds_user_id)
        {
            userAgent = new ProductInfoHeaderValue("(Instagram 219.0.0.12.117 Android)");
            httpClient = new HttpClient();
            cookies = $"sessionid={sessionId};ds_user_id={ds_user_id}";
        }
        private async Task<T?> GetResponseAsync<T>(Uri requestUri) where T : class
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            request.Headers.UserAgent.Add(userAgent);
            request.Headers.Add("Cookie", cookies);

            HttpResponseMessage? response = await httpClient.SendAsync(request);
            try
            {
                response.EnsureSuccessStatusCode();
                string? json = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private Uri BuildUrl(string relativeurl)
        {
            return new Uri($"{BASE_URL}{relativeurl}");
        }

        /// <summary>
        /// Get the basic information about an user asynchronously
        /// </summary>
        /// <param name="username">username to search</param>
        /// <returns>a <see cref="WebProfileInfoViewModel"/> object containing all the information about a user</returns>
        public async Task<WebProfileInfoViewModel?> GetUserInfoAsync(string username)
        {
            var url = BuildUrl($"users/web_profile_info/?username={username}");
            return await this.GetResponseAsync<WebProfileInfoViewModel>(url);
        }


        /// <summary>
        /// Get the followers list of an user asynchronously
        /// </summary>
        /// <param name="userId">user id returned by <see cref="GetUserInfoAsync"/> to search</param>
        /// <returns>a <see cref="FollowersViewModel"/> object containing a list of users</returns>
        public async Task<FollowersViewModel> GetUserFollowersAsync(string userId)
        {
            var maxId = "0";
            FollowersViewModel finalResponse = new FollowersViewModel();
            finalResponse.users = new List<Follower>();
            var shouldContinue = true;
            do
            {
                var url = BuildUrl($"friendships/{userId}/followers/?count=50&max_id={maxId}&search_surface=follow_list_page");
                var followers = await this.GetResponseAsync<FollowersViewModel>(url);
                finalResponse.users.AddRange(followers?.users);
                if (followers.next_max_id == null || string.IsNullOrWhiteSpace(followers.next_max_id))
                {
                    shouldContinue = false;
                }
                else
                {
                    maxId = followers.next_max_id;
                }

            } while (shouldContinue);

            return finalResponse;
        }

        /// <summary>
        /// Get the following list of an user asynchronously
        /// </summary>
        /// <param name="userId">user id returned by <see cref="GetUserInfoAsync"/> to search</param>
        /// <returns>a <see cref="FollowingViewModel"/> object containing a list of users</returns>
        public async Task<FollowingViewModel> GetUserFollowingAsync(string userId)
        {
            var maxId = "0";
            FollowingViewModel finalResponse = new FollowingViewModel();
            finalResponse.users = new List<Following>();
            var shouldContinue = true;
            do
            {
                var url = BuildUrl($"friendships/{userId}/followers/?count=50&max_id={maxId}&search_surface=follow_list_page");
                var following = await this.GetResponseAsync<FollowingViewModel>(url);
                finalResponse.users.AddRange(following?.users);
                if (following.next_max_id == null || string.IsNullOrWhiteSpace(following.next_max_id))
                {
                    shouldContinue = false;
                }
                else
                {
                    maxId = following.next_max_id;
                }

            } while (shouldContinue);

            return finalResponse;
        }
        /// <summary>
        /// Get the feed of an user asynchronously
        /// </summary>
        /// <param name="userId">user id returned by <see cref="GetUserInfoAsync"/> to search</param>
        /// <returns>a <see cref="FeedViewModel"/> object containing a list of media</returns>
        public async Task<FeedViewModel> GetUserFeed(string userId)
        {
            var maxId = "0";
            FeedViewModel finalResponse = new FeedViewModel();
            finalResponse.items = new List<Models.Feed.Item>();
            var shouldContinue = true;
            do
            {
                var url = BuildUrl($"feed/user/{userId}/?count=12&max_id={maxId}");
                var feed = await this.GetResponseAsync<FeedViewModel>(url);

                finalResponse.items.AddRange(feed?.items);

                maxId = feed.next_max_id;
                shouldContinue = feed.more_available;

            } while (shouldContinue);

            return finalResponse;
        }
        /// <summary>
        /// Get the likers of a media asynchronously
        /// </summary>
        /// <param name="mediaId">media id to search</param>
        /// <returns>a <see cref="FeedViewModel"/> object containing a list of media</returns>
        public async Task<LikersViewModel?> GetMediaLikers(string mediaId)
        {
            var url = BuildUrl($"media/{mediaId}/likers/");
            return await this.GetResponseAsync<LikersViewModel>(url);
        }
        /// <summary>
        /// Get infos of a media asynchronously
        /// </summary>
        /// <param name="mediaId">media id to search</param>
        /// <returns>a <see cref="MediaInfoViewModel"/> object containing the info of a media</returns>
        public async Task<MediaInfoViewModel?> GetMediaInfo(string mediaId)
        {
            var url = BuildUrl($"media/{mediaId}/info/");
            return await this.GetResponseAsync<MediaInfoViewModel>(url);
        }
    }
}