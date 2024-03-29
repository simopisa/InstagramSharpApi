﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramWrapper.Models.ProfileInfo
{
    public class WebProfileInfoViewModel
    {
        public Data data { get; set; }
        public string status { get; set; }
    }

    public class BiographyWithEntities
    {
        public string raw_text { get; set; }
        public List<object> entities { get; set; }
    }

    public class CoauthorProducer
    {
        public string id { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class DashInfo
    {
        public bool is_dash_eligible { get; set; }
        public string video_dash_manifest { get; set; }
        public int number_of_qualities { get; set; }
    }

    public class Data
    {
        public User user { get; set; }
    }

    public class Dimensions
    {
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Edge
    {
        public Node node { get; set; }
    }

    public class EdgeFelixCombinedDraftUploads
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeFelixCombinedPostUploads
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeFelixDrafts
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeFelixPendingDraftUploads
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeFelixPendingPostUploads
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeFelixVideoTimeline
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeFollow
    {
        public int count { get; set; }
    }

    public class EdgeFollowedBy
    {
        public int count { get; set; }
    }

    public class EdgeLikedBy
    {
        public int count { get; set; }
    }

    public class EdgeMediaCollections
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeMediaPreviewLike
    {
        public int count { get; set; }
    }

    public class EdgeMediaToCaption
    {
        public List<Edge> edges { get; set; }
    }

    public class EdgeMediaToComment
    {
        public int count { get; set; }
    }

    public class EdgeMediaToTaggedUser
    {
        public List<Edge> edges { get; set; }
    }

    public class EdgeMutualFollowedBy
    {
        public int count { get; set; }
        public List<object> edges { get; set; }
    }

    public class EdgeOwnerToTimelineMedia
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<Edge> edges { get; set; }
    }

    public class EdgeSavedMedia
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public List<Edge> edges { get; set; }
    }

    public class EdgeSidecarToChildren
    {
        public List<Edge> edges { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public bool has_public_page { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Node
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string shortcode { get; set; }
        public Dimensions dimensions { get; set; }
        public string display_url { get; set; }
        public EdgeMediaToTaggedUser edge_media_to_tagged_user { get; set; }
        public object fact_check_overall_rating { get; set; }
        public object fact_check_information { get; set; }
        public object gating_info { get; set; }
        public SharingFrictionInfo sharing_friction_info { get; set; }
        public object media_overlay_info { get; set; }
        public string media_preview { get; set; }
        public Owner owner { get; set; }
        public bool is_video { get; set; }
        public bool has_upcoming_event { get; set; }
        public string accessibility_caption { get; set; }
        public EdgeMediaToCaption edge_media_to_caption { get; set; }
        public EdgeMediaToComment edge_media_to_comment { get; set; }
        public bool comments_disabled { get; set; }
        public int taken_at_timestamp { get; set; }
        public EdgeLikedBy edge_liked_by { get; set; }
        public EdgeMediaPreviewLike edge_media_preview_like { get; set; }
        public Location location { get; set; }
        public object nft_asset_info { get; set; }
        public string thumbnail_src { get; set; }
        public List<ThumbnailResource> thumbnail_resources { get; set; }
        public List<object> coauthor_producers { get; set; }
        public List<object> pinned_for_users { get; set; }
        public bool viewer_can_reshare { get; set; }
        public EdgeSidecarToChildren edge_sidecar_to_children { get; set; }
        public User user { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public string text { get; set; }
        public DashInfo dash_info { get; set; }
        public bool has_audio { get; set; }
        public string tracking_token { get; set; }
        public string video_url { get; set; }
        public int video_view_count { get; set; }
        public object felix_profile_grid_crop { get; set; }
        public string product_type { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string username { get; set; }
    }

    public class PageInfo
    {
        public bool has_next_page { get; set; }
        public string end_cursor { get; set; }
    }

    public class PinnedForUser
    {
        public string id { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }



    public class SharingFrictionInfo
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
    }

    public class ThumbnailResource
    {
        public string src { get; set; }
        public int config_width { get; set; }
        public int config_height { get; set; }
    }

    public class User
    {
        public string biography { get; set; }
        public List<object> bio_links { get; set; }
        public BiographyWithEntities biography_with_entities { get; set; }
        public bool blocked_by_viewer { get; set; }
        public bool restricted_by_viewer { get; set; }
        public bool country_block { get; set; }
        public object external_url { get; set; }
        public object external_url_linkshimmed { get; set; }
        public EdgeFollowedBy edge_followed_by { get; set; }
        public string fbid { get; set; }
        public bool followed_by_viewer { get; set; }
        public EdgeFollow edge_follow { get; set; }
        public bool follows_viewer { get; set; }
        public string full_name { get; set; }
        public object group_metadata { get; set; }
        public bool has_ar_effects { get; set; }
        public bool has_clips { get; set; }
        public bool has_guides { get; set; }
        public bool has_channel { get; set; }
        public bool has_blocked_viewer { get; set; }
        public int highlight_reel_count { get; set; }
        public bool has_requested_viewer { get; set; }
        public bool hide_like_and_view_counts { get; set; }
        public string id { get; set; }
        public bool is_business_account { get; set; }
        public bool is_professional_account { get; set; }
        public bool is_supervision_enabled { get; set; }
        public bool is_guardian_of_viewer { get; set; }
        public bool is_supervised_by_viewer { get; set; }
        public bool is_supervised_user { get; set; }
        public bool is_embeds_disabled { get; set; }
        public bool is_joined_recently { get; set; }
        public object guardian_id { get; set; }
        public object business_address_json { get; set; }
        public string business_contact_method { get; set; }
        public object business_email { get; set; }
        public object business_phone_number { get; set; }
        public object business_category_name { get; set; }
        public object overall_category_name { get; set; }
        public object category_enum { get; set; }
        public string category_name { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public EdgeMutualFollowedBy edge_mutual_followed_by { get; set; }
        public string profile_pic_url { get; set; }
        public string profile_pic_url_hd { get; set; }
        public bool requested_by_viewer { get; set; }
        public bool should_show_category { get; set; }
        public bool should_show_public_contacts { get; set; }
        public object show_account_transparency_details { get; set; }
        public object transparency_label { get; set; }
        public string transparency_product { get; set; }
        public string username { get; set; }
        public object connected_fb_page { get; set; }
        public List<object> pronouns { get; set; }
        public EdgeFelixCombinedPostUploads edge_felix_combined_post_uploads { get; set; }
        public EdgeFelixCombinedDraftUploads edge_felix_combined_draft_uploads { get; set; }
        public EdgeFelixVideoTimeline edge_felix_video_timeline { get; set; }
        public EdgeFelixDrafts edge_felix_drafts { get; set; }
        public EdgeFelixPendingPostUploads edge_felix_pending_post_uploads { get; set; }
        public EdgeFelixPendingDraftUploads edge_felix_pending_draft_uploads { get; set; }
        public EdgeOwnerToTimelineMedia edge_owner_to_timeline_media { get; set; }
        public EdgeSavedMedia edge_saved_media { get; set; }
        public EdgeMediaCollections edge_media_collections { get; set; }
    }


}
