using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskOfFear : Template
    {
        public static readonly Guid ID = Guid.Parse("a1aa3928-69bf-4bac-a502-944398942350");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask of Fear",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this reaction even if you have a condition tied to the frightened condition that would normally prevent you from using a reaction, such as “fleeing as long as you're frightened” or “paralyzed as long as you're frightened.”",
                Trigger = "You start your turn with the frightened condition.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f27a95d4-bbce-473e-aead-58e8b7893fd5"), Type = TextBlockType.Text, Text = "Your warmask burns off of your face, releasing your apprehension. You remove the frightened condition. Your warmask is destroyed, and you can’t reapply it until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bbf0e210-0e8d-458f-ab3b-9faedc0cb77e"), Feats.Instances.OrcWarmask.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b51d146d-ba58-4c88-9085-3ee65a077b38"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
