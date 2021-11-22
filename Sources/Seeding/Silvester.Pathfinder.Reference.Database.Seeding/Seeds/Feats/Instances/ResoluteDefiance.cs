using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResoluteDefiance : Template
    {
        public static readonly Guid ID = Guid.Parse("ee6feb92-7819-4a00-b52d-f088d0b23d63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resolute Defiance",
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
            yield return new TextBlock { Id = Guid.Parse("a621b8b9-2bbd-43d5-8509-e75ff3c4c77e"), Type = TextBlockType.Text, Text = "The shield gains a +2 status bonus to its Hardness and gains temporary Hit Points equal to your level + 2 that last until the essence effect ends. If you don't have the (feat: Shield Block) reaction, you gain it while your shield is manifested." };
            yield return new TextBlock { Id = Guid.Parse("a9e5fce1-c63b-4a99-9816-3566d0194460"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ When you take damage while (action: Raising a Shield | Raise a Shield) or use (feat: Shield Block), attempt a DC 5 flat check. If you fail, the shield is (action: Dismissed | Dismiss) if it's your soulforged armament or dropped if it's a different shield." };
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
                Id = Guid.Parse("4dbd8310-ca50-4efa-a7db-b65f7064e5c2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
