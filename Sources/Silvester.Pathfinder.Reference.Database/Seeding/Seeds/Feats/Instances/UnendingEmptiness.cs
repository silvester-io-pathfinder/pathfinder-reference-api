using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnendingEmptiness : Template
    {
        public static readonly Guid ID = Guid.Parse("577495f1-f323-4179-938e-caf676a17d7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unending Emptiness",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c048f12-be38-4d05-a63a-c24260107c03"), Type = TextBlockType.Text, Text = "You pool the power of shadow within your eyes, gaining the ability to gather darkness into a turbulent orb of crushing emptiness within your line of sight. You gain the (spell: darklight) domain spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("b5d04964-00c2-4787-8041-13c803c5bb8a"));
            builder.HaveSpecificFeat(Guid.Parse("349697e9-acd0-4eda-9b63-bed21cf7f5ea"), Feats.Instances.ShadowcasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d31f264-eeef-41ea-8e73-61a409c2924e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
