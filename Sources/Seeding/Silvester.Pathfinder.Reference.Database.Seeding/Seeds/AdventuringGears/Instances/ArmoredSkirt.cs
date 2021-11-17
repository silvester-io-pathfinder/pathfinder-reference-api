using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class ArmoredSkirt : Template
    {
        public static readonly Guid ID = Guid.Parse("29638790-400f-407e-8b44-0b25aff858cd");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Armored Skirt",
                Hands = "0",
                Price = 200,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cd9831c4-0711-4425-8858-18cc1d989a7a"), Type = TextBlockType.Text, Text = "These armor-plated skirts, which are also known as armored kilts, are favored by Knights of Lastwall for their versatility and aesthetic appeal. An armored skirt can be donned with 2 Interact actions when it’s worn with light or medium armor, or as part of donning heavy armor." };
            yield return new TextBlock { Id = Guid.Parse("f0165037-edad-4df1-997e-81daf61a4399"), Type = TextBlockType.Text, Text = "When worn with a breastplate, chain shirt, chain mail, or scale mail, an armored skirt increases the armor’s item bonus to AC by 1, worsens the armor’s check penalty by 1, reduces the armor’s Dex cap by 1, increases the Strength score required to ignore the check penalty and reduce the Speed penalty by 2, and adds the noisy trait. This also makes the armor one step heavier (from light to medium, or medium to heavy), and you use the proficiency bonus appropriate to this adjusted armor type." };
            yield return new TextBlock { Id = Guid.Parse("b47ed716-9fe1-4fa9-80be-b68a2c7dcc53"), Type = TextBlockType.Text, Text = "Alternatively, when wearing an armored skirt to replace appropriate portions of a set of half plate or full plate, reduce the armor’s item bonus to AC by 1, lessen the check penalty by 1, decrease the Strength score required to ignore the check penalty and reduce the Speed penalty by 2, increase the armor’s Dex cap by 1, and add the noisy trait to the armor. An armored skirt grants no benefit when worn by itself or with armors other than those listed here." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a1fa3d5-1b85-41e3-8eb6-d17fd109079f"),
                SourceId = CharacterGuide.ID,
                Page = 91
            };
        }
    }
}
