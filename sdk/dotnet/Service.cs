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
    /// Manages Services (e.g elasticsearch-prod, redis-preprod, customer-postgresql-prod).
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
    ///         var foo = new Rootly.Service("foo", new Rootly.ServiceArgs
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
    ///  $ pulumi import rootly:index/service:Service foo 11111111-2222-3333-4444-555555555555
    /// ```
    /// </summary>
    [RootlyResourceType("rootly:index/service:Service")]
    public partial class Service : Pulumi.CustomResource
    {
        /// <summary>
        /// The color chosen for the service
        /// </summary>
        [Output("color")]
        public Output<string?> Color { get; private set; } = null!;

        /// <summary>
        /// For internal use only
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The name of the service
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// This will be displayed on your status pages to explain to your customer the use of this service.
        /// </summary>
        [Output("publicDescription")]
        public Output<string?> PublicDescription { get; private set; } = null!;

        /// <summary>
        /// The slug of the service
        /// </summary>
        [Output("slug")]
        public Output<string> Slug { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs? args = null, CustomResourceOptions? options = null)
            : base("rootly:index/service:Service", name, args ?? new ServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
            : base("rootly:index/service:Service", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new Service(name, id, state, options);
        }
    }

    public sealed class ServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The color chosen for the service
        /// </summary>
        [Input("color")]
        public Input<string>? Color { get; set; }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the service
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// This will be displayed on your status pages to explain to your customer the use of this service.
        /// </summary>
        [Input("publicDescription")]
        public Input<string>? PublicDescription { get; set; }

        /// <summary>
        /// The slug of the service
        /// </summary>
        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public ServiceArgs()
        {
        }
    }

    public sealed class ServiceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The color chosen for the service
        /// </summary>
        [Input("color")]
        public Input<string>? Color { get; set; }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the service
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// This will be displayed on your status pages to explain to your customer the use of this service.
        /// </summary>
        [Input("publicDescription")]
        public Input<string>? PublicDescription { get; set; }

        /// <summary>
        /// The slug of the service
        /// </summary>
        [Input("slug")]
        public Input<string>? Slug { get; set; }

        public ServiceState()
        {
        }
    }
}
