using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramCommentScraper
{
    class ExploreModel
    {
        public Config config { get; set; }
        public string country_code { get; set; }
        public string language_code { get; set; }
        public string locale { get; set; }
        public EntryData entry_data { get; set; }
        public string hostname { get; set; }
        public bool is_whitelisted_crawl_bot { get; set; }
        public string deployment_stage { get; set; }
        public string platform { get; set; }
        public string nonce { get; set; }
        public double mid_pct { get; set; }
        public bool is_dev { get; set; }
        public string rollout_hash { get; set; }
        public string bundle_variant { get; set; }
        public string frontend_env { get; set; }
    }
    public class Config
    {
        public string csrf_token { get; set; }
        public object viewer { get; set; }
        public object viewerId { get; set; }
    }

    public class EdgeFollowedBy
    {
        public int count { get; set; }
    }

    public class EdgeFollow
    {
        public int count { get; set; }
    }

    public class EdgeMutualFollowedBy
    {
        public int count { get; set; }
        public IList<object> edges { get; set; }
    }

    public class PageInfo
    {
        public bool has_next_page { get; set; }
        public object end_cursor { get; set; }
    }

    public class EdgeFelixVideoTimeline
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public IList<object> edges { get; set; }
    }

    public class Dimensions
    {
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string username { get; set; }
    }

    public class Edge
    {
        public Node node { get; set; }
    }

    public class EdgeMediaToCaption
    {
        public IList<Edge> edges { get; set; }
    }

    public class EdgeMediaToComment
    {
        public int count { get; set; }
    }

    public class EdgeLikedBy
    {
        public int count { get; set; }
    }

    public class EdgeMediaPreviewLike
    {
        public int count { get; set; }
    }

    public class ThumbnailResource
    {
        public string src { get; set; }
        public int config_width { get; set; }
        public int config_height { get; set; }
    }

    public class EdgeSidecarToChildren
    {
        public List<Edge> edges { get; set; }
    }

    public class Node
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string shortcode { get; set; }
        public string display_url { get; set; }
        public object gating_info { get; set; }
        public object fact_check_overall_rating { get; set; }
        public object fact_check_information { get; set; }
        public object media_overlay_info { get; set; }
        public string media_preview { get; set; }
        public bool is_video { get; set; }
        public string accessibility_caption { get; set; }
        public bool comments_disabled { get; set; }
        public int taken_at_timestamp { get; set; }
        public object location { get; set; }
        public string thumbnail_src { get; set; }
        public object felix_profile_grid_crop { get; set; }
        public int video_view_count { get; set; }
        public EdgeSidecarToChildren edge_sidecar_to_children { get; set; }
    }


    public class EdgeOwnerToTimelineMedia
    {
        public int count { get; set; }
        public List<Edge> edges { get; set; }
    }

    public class EdgeSavedMedia
    {
        public int count { get; set; }
        public List<object> edges { get; set; }
    }

    public class User
    {
        public EdgeOwnerToTimelineMedia edge_owner_to_timeline_media { get; set; }
        public string biography { get; set; }
        public bool blocked_by_viewer { get; set; }
        public object restricted_by_viewer { get; set; }
        public bool country_block { get; set; }
        public object external_url { get; set; }
        public object external_url_linkshimmed { get; set; }
        public bool follows_viewer { get; set; }
        public string full_name { get; set; }
        public bool has_ar_effects { get; set; }
        public bool has_channel { get; set; }
        public bool has_blocked_viewer { get; set; }
        public int highlight_reel_count { get; set; }
        public bool has_requested_viewer { get; set; }
        public string id { get; set; }
        public bool is_business_account { get; set; }
        public bool is_joined_recently { get; set; }
        public string business_category_name { get; set; }
        public string category_id { get; set; }
        public object overall_category_name { get; set; }
        public string category_enum { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string profile_pic_url_hd { get; set; }
        public bool requested_by_viewer { get; set; }
        public string username { get; set; }
        public object connected_fb_page { get; set; }
    }

    public class Graphql
    {
        public User user { get; set; }
    }

    public class ProfilePage
    {
        public string logging_page_id { get; set; }
        public bool show_suggested_profiles { get; set; }
        public bool show_follow_dialog { get; set; }
        public Graphql graphql { get; set; }
        public object toast_content_on_load { get; set; }
    }

    public class EntryData
    {
        public IList<ProfilePage> ProfilePage { get; set; }
    }


}
