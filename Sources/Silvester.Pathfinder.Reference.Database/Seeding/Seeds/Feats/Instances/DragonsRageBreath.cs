using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonsRageBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("b43b1d8b-6a4f-49a1-8175-e5c55a2a0297");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon's Rage Breath",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("197d022e-c3ba-420d-8a56-b0cdcfebd30f"), Type = TextBlockType.Text, Text = "You breathe deeply and exhale powerful energy in a 30-foot cone or 60-foot line, dealing 1d6 damage per level. The area and damage type match those of your dragon (see Dragon Instincts table). If you used this ability in the last hour, the area and the damage are halved (15-foot cone or 30-foot line; 1d6 damage for every 2 levels). Each creature in the area must attempt a basic Reflex save." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("4d2b1653-4020-45a6-8b68-d897cc913cb3"), Instincts.Instances.DragonInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34753724-a0d7-418f-9100-fa02cdf8e79e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
