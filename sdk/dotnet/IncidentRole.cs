// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Rootly
{
    /// <summary>
    /// Manages Incident Roles (e.g Commander, Ops Lead, Communication).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Rootly = Pulumi.Rootly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var foo = new Rootly.IncidentRole("foo", new Rootly.IncidentRoleArgs
    ///         {
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import rootly:index/incidentRole:IncidentRole foo 11111111-2222-3333-4444-555555555555
    /// ```
    /// </summary>
    [RootlyResourceType("rootly:index/incidentRole:IncidentRole")]
    public partial class IncidentRole : Pulumi.CustomResource
    {
        /// <summary>
        /// The description of the incident role
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Whether the incident role is enabled or not
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The name of the incident role
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The summary of the incident role
        /// </summary>
        [Output("summary")]
        public Output<string?> Summary { get; private set; } = null!;


        /// <summary>
        /// Create a IncidentRole resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IncidentRole(string name, IncidentRoleArgs? args = null, CustomResourceOptions? options = null)
            : base("rootly:index/incidentRole:IncidentRole", name, args ?? new IncidentRoleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IncidentRole(string name, Input<string> id, IncidentRoleState? state = null, CustomResourceOptions? options = null)
            : base("rootly:index/incidentRole:IncidentRole", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/rootlyhq/pulumi-rootly/releases/v${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IncidentRole resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IncidentRole Get(string name, Input<string> id, IncidentRoleState? state = null, CustomResourceOptions? options = null)
        {
            return new IncidentRole(name, id, state, options);
        }
    }

    public sealed class IncidentRoleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the incident role
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether the incident role is enabled or not
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the incident role
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The summary of the incident role
        /// </summary>
        [Input("summary")]
        public Input<string>? Summary { get; set; }

        public IncidentRoleArgs()
        {
        }
    }

    public sealed class IncidentRoleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the incident role
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether the incident role is enabled or not
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The name of the incident role
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The summary of the incident role
        /// </summary>
        [Input("summary")]
        public Input<string>? Summary { get; set; }

        public IncidentRoleState()
        {
        }
    }
}
