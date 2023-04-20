using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramWrapper.Models.Likers
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Candidate
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public string scans_profile { get; set; }
        public List<int> estimated_scans_sizes { get; set; }
    }

    public class Caption
    {
        public string pk { get; set; }
        public long user_id { get; set; }
        public string text { get; set; }
        public int type { get; set; }
        public int created_at { get; set; }
        public int created_at_utc { get; set; }
        public string content_type { get; set; }
        public string status { get; set; }
        public int bit_flags { get; set; }
        public bool did_report_as_spam { get; set; }
        public bool share_enabled { get; set; }
        public User user { get; set; }
        public bool is_covered { get; set; }
        public bool is_ranked_comment { get; set; }
        public long media_id { get; set; }
        public bool has_translation { get; set; }
        public int private_reply_status { get; set; }
    }

    public class CarouselMedium
    {
        public string id { get; set; }
        public int media_type { get; set; }
        public ImageVersions2 image_versions2 { get; set; }
        public int original_width { get; set; }
        public int original_height { get; set; }
        public object pk { get; set; }
        public string carousel_parent_id { get; set; }
        public string commerciality_status { get; set; }
        public SharingFrictionInfo sharing_friction_info { get; set; }
    }

    public class CommentInformTreatment
    {
        public bool should_have_inform_treatment { get; set; }
        public string text { get; set; }
        public object url { get; set; }
        public object action_type { get; set; }
    }

    public class FanClubInfo
    {
        public object fan_club_id { get; set; }
        public object fan_club_name { get; set; }
        public object is_fan_club_referral_eligible { get; set; }
        public object fan_consideration_page_revamp_eligiblity { get; set; }
        public object is_fan_club_gifting_eligible { get; set; }
    }

    public class FriendshipStatus
    {
        public bool following { get; set; }
        public bool outgoing_request { get; set; }
        public bool is_bestie { get; set; }
        public bool is_restricted { get; set; }
        public bool is_feed_favorite { get; set; }
    }

    public class FundraiserTag
    {
        public bool has_standalone_fundraiser { get; set; }
    }

    public class ImageVersions2
    {
        public List<Candidate> candidates { get; set; }
    }

    public class Location
    {
        public long pk { get; set; }
        public string short_name { get; set; }
        public long facebook_places_id { get; set; }
        public string external_source { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public bool has_viewer_saved { get; set; }
        public double lng { get; set; }
        public double lat { get; set; }
        public bool is_eligible_for_guides { get; set; }
    }

    public class MediaInfo
    {
        public int taken_at { get; set; }
        public long pk { get; set; }
        public string id { get; set; }
        public long device_timestamp { get; set; }
        public string code { get; set; }
        public string client_cache_key { get; set; }
        public int filter_type { get; set; }
        public bool is_unified_video { get; set; }
        public bool should_request_ads { get; set; }
        public bool original_media_has_visual_reply_media { get; set; }
        public bool like_and_view_counts_disabled { get; set; }
        public string commerciality_status { get; set; }
        public bool is_paid_partnership { get; set; }
        public bool is_visual_reply_commenter_notice_enabled { get; set; }
        public List<object> clips_tab_pinned_user_ids { get; set; }
        public bool has_delayed_metadata { get; set; }
        public FundraiserTag fundraiser_tag { get; set; }
        public Location location { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public bool comment_likes_enabled { get; set; }
        public bool comment_threading_enabled { get; set; }
        public int max_num_visible_preview_comments { get; set; }
        public bool has_more_comments { get; set; }
        public List<object> preview_comments { get; set; }
        public int carousel_media_count { get; set; }
        public List<CarouselMedium> carousel_media { get; set; }
        public bool can_see_insights_as_brand { get; set; }
        public bool photo_of_you { get; set; }
        public bool is_organic_product_tagging_eligible { get; set; }
        public User user { get; set; }
        public bool can_viewer_reshare { get; set; }
        public int like_count { get; set; }
        public bool has_liked { get; set; }
        public bool is_comments_gif_composer_enabled { get; set; }
        public Caption caption { get; set; }
        public bool caption_is_edited { get; set; }
        public CommentInformTreatment comment_inform_treatment { get; set; }
        public SharingFrictionInfo sharing_friction_info { get; set; }
        public bool can_viewer_save { get; set; }
        public bool is_in_profile_grid { get; set; }
        public bool profile_grid_control_enabled { get; set; }
        public string organic_tracking_token { get; set; }
        public int has_shared_to_fb { get; set; }
        public string product_type { get; set; }
        public bool show_shop_entrypoint { get; set; }
        public int deleted_reason { get; set; }
        public string integrity_review_decision { get; set; }
        public object commerce_integrity_review_decision { get; set; }
        public MusicMetadata music_metadata { get; set; }
        public bool is_artist_pick { get; set; }
        public bool ig_media_sharing_disabled { get; set; }
        public bool can_view_more_preview_comments { get; set; }
        public int comment_count { get; set; }
        public bool hide_view_all_comment_entrypoint { get; set; }
    }

    public class MusicMetadata
    {
        public string music_canonical_id { get; set; }
        public object audio_type { get; set; }
        public object music_info { get; set; }
        public object original_sound_info { get; set; }
        public object pinned_media_ids { get; set; }
    }

    public class LikersViewModel
    {
        public List<User> users { get; set; }
        public int user_count { get; set; }
        public MediaInfo media_info { get; set; }
        public string disclaimer_text { get; set; }
        public string status { get; set; }
    }

    public class SharingFrictionInfo
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
        public object sharing_friction_payload { get; set; }
    }

    public class User
    {
        public object pk { get; set; }
        public string pk_id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public List<object> account_badges { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public int latest_reel_media { get; set; }
        public string profile_pic_id { get; set; }
    }

    public class User2
    {
        public bool has_anonymous_profile_picture { get; set; }
        public FanClubInfo fan_club_info { get; set; }
        public bool transparency_product_enabled { get; set; }
        public bool is_favorite { get; set; }
        public bool is_unpublished { get; set; }
        public long pk { get; set; }
        public string pk_id { get; set; }
        public string strong_id__ { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public FriendshipStatus friendship_status { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public List<object> account_badges { get; set; }
        public bool is_verified { get; set; }
        public string fbid_v2 { get; set; }
    }


}
