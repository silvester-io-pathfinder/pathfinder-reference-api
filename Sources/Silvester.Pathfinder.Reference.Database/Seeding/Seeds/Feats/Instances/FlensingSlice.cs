using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlensingSlice : Template
    {
        public static readonly Guid ID = Guid.Parse("305db87c-b8de-41ed-aa3e-fbae1932f021");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flensing Slice",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d733a57-afe8-4ae2-be6e-7c267f5b77a4"), Type = TextBlockType.Text, Text = "When you hit with both attacks with (feat: Double Slice), you flense the target, making it bleed and creating a weak spot. The target takes 1d8 persistent bleed damage per weapon damage die of whichever of the weapons you used that has the most weapon damage dice (maximum 4d8 for a (item: major striking | Major Striking Runestone) weapon). The target becomes flat-footed, and its resistances to any physical damage types are reduced by 5; these two effects last until the beginning of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fd6af9b6-1de1-4bdc-a1b1-2d2111501bd4"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33b0c805-fd68-4f49-aff5-088dc9c62156"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
