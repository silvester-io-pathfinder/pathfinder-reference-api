using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetabolizeElement : Template
    {
        public static readonly Guid ID = Guid.Parse("ba1e45ce-d89e-480e-97e1-e43ff125e183");

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
            yield return new TextBlock { Id = Guid.Parse("728f1149-4e78-427f-af5f-79bb8716c392"), Type = TextBlockType.Text, Text = "Your rapidly metabolize the elemental particles in your opponent’s spell to gain a boost of energy. You gain the quickened condition until the end of your next turn. You can use the extra action only to (action: Step) or (action: Stride)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d68fc014-b954-4100-9302-5c7038325675"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52a50949-4052-4eb7-a822-2ce2606a7cbe"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
