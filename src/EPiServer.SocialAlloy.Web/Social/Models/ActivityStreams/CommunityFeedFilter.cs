﻿namespace EPiServer.SocialAlloy.Web.Social.Repositories
{
    /// <summary>
    /// The CommunityFeedFilter class exposes a set of properties to filter
    /// the retrieval of social activity feed items.
    public class CommunityFeedFilter
    {
        /// <summary>
        /// Gets or sets a subscriber by which the result set of
        /// feed items should be filtered.
        /// </summary>
        public string Subscriber { get; set; }

        /// <summary>
        /// The maximum number of activity feed items to retrieve.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// The offset to start retrieving the next page of activity feed items from.
        /// </summary>
        public int PageOffset { get; set; }
    }
}