using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoundingSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("2fafcc6f-4a44-47be-a426-da1c16d7409e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bounding Spirit",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f087ca69-16b1-44fb-8d44-faa3bb54d3c1"), Type = TextBlockType.Text, Text = "The weapon gains the (trait: thrown 30 feet|thrown 30 feet) trait and has the (item: returning rune|Returning Runestone) (even if it already has its maximum number of property runes)." };
            yield return new TextBlock { Id = Guid.Parse("34d6f389-c2b5-41a5-9af4-788aecdec164"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ When you make a (action: Strike) with a thrown or ranged weapon and miss, reroll the (action: Strike), targeting your ally nearest to the tar" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df7c945d-83c1-4746-98de-0d1cf488c8e7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
