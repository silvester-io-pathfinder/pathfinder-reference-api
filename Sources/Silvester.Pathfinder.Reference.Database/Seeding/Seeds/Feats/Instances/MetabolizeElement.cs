using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetabolizeElement : Template
    {
        public static readonly Guid ID = Guid.Parse("f582599b-1a83-450c-92da-b4581eb6d842");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Metabolize Element",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage from a foe's spell or magical ability with the air, earth, fire, or water trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e23b2e7-baf2-4606-81b4-ca23067148b9"), Type = TextBlockType.Text, Text = "Your rapidly metabolize the elemental particles in your opponent’s spell to gain a boost of energy. You gain the quickened condition until the end of your next turn. You can use the extra action only to (action: Step) or (action: Stride)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7e6cda09-a636-40ec-aca3-206fb3375340"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a84a4ee-9a7b-40e4-8e1d-6d2f1f56ec18"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
