using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramWrapper.Models.Following
{
    public class FollowingViewModel
    {
        public List<Following> users { get; set; }
        public bool big_list { get; set; }
        public int page_size { get; set; }
        public string? next_max_id { get; set; }
        public bool has_more { get; set; }
        public bool should_limit_list_of_followers { get; set; }
        public string status { get; set; }
    }

    public class Following
    {
        public bool has_anonymous_profile_picture { get; set; }
        public object pk { get; set; }
        public string pk_id { get; set; }
        public string strong_id__ { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public List<object> account_badges { get; set; }
        public int latest_reel_media { get; set; }
        public bool is_favorite { get; set; }
    }


}
