using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResoluteDefiance : Template
    {
        public static readonly Guid ID = Guid.Parse("3b3e89fc-e038-4530-9b96-9315fd626575");

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
            yield return new TextBlock { Id = Guid.Parse("f9ef7613-2656-46dd-adf9-0e155aae1782"), Type = TextBlockType.Text, Text = "The shield gains a +2 status bonus to its Hardness and gains temporary Hit Points equal to your level + 2 that last until the essence effect ends. If you don’t have the (feat: Shield Block) reaction, you gain it while your shield is manifested." };
            yield return new TextBlock { Id = Guid.Parse("e114b662-1ae9-4f45-a7a7-6c81d0fe892c"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ When you take damage while (action: Raising a Shield | Raise a Shield) or use (feat: Shield Block), attempt a DC 5 flat check. If you fail, the shield is (action: Dismissed | Dismiss) if it’s your soulforged armament or dropped if it’s a different shield." };
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
                Id = Guid.Parse("2c1aa0e4-0cff-401f-8a8c-0d34740a8232"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
