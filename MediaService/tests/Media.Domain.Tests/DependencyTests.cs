// <copyright>
// Copyright (c) Martin Bohring. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
// </copyright>

namespace Media.Domain.Tests
{
    using Shouldly;

    public sealed class DependencyTests
    {
        [Input("AutoFixture")]
        [Input("AutoFixture.Idioms")]
        [Input("Media.Domain.Tests")]
        [Input("Shouldly")]
        [Input("Fixie")]
        public void MediaDomainShouldNotReference(string assemblyName)
        {
            var references = typeof(ValueObject<>).Assembly.GetReferencedAssemblies();

            references.ShouldNotContain(reference => reference.Name == assemblyName);
        }
    }
}
