using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    /// <summary>
    /// organization teams
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Team
    {
        /// <summary>
        /// url for this team
        /// </summary>
        public Uri Url { get; protected set; }

        /// <summary>
        /// team id
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// team name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// permission attached to this team
        /// </summary>
        public Permission Permission { get; protected set; }

        /// <summary>
        /// how many members in this team
        /// </summary>
        public int MembersCount { get; protected set; }

        /// <summary>
        /// how many repo this team has access to
        /// </summary>
        public int ReposCount { get; protected set; }

        /// <summary>
        /// who this team belongs to
        /// </summary>
        public Organization Organization { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return String.Format(CultureInfo.InvariantCulture, "Name: {0} ", Name); }
        }
    }
}
