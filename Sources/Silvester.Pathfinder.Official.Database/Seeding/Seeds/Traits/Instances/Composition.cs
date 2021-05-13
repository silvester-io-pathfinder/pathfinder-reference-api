using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Composition : Template
    {
        public static readonly Guid ID = Guid.Parse("c8af0a33-b654-4e7a-bc58-88152f9dd4d0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Composition",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f13852bc-73a7-421a-8337-2bc140eebc49"), Type = TextBlockType.Text, Text = "To cast a composition cantrip or focus spell, you usually use a type of Performance. If the spell includes a verbal component, you must use an auditory performance, and if it includes a somatic component, you must use a visual one. The spell gains all the traits of the performance you used. You can cast only one composition spell each turn, and you can have only one active at a time. If you cast a new composition spell, any ongoing effects from your previous composition spell end immediately." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("809e3884-a7fc-46ee-a7fb-87e22ff3acff"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
