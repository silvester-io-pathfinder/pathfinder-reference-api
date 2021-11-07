using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainQuake : Template
    {
        public static readonly Guid ID = Guid.Parse("98372139-4483-4d67-ade4-12660112a371");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain Quake",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, the Dexterity modifier cap to your AC while using Mountain Stance increases from +1 to +2.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b903480d-cdd6-4638-8a62-ef133403fd50"), Type = TextBlockType.Text, Text = "You stomp, shaking the earth beneath you. Creatures on the ground within a 20-foot emanation take damage equal to your Strength modifier (minimum 0), which they can resist with a basic Fortitude save. On a failure, they also fall prone. After you use this action, you can’t use it again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1be332a8-938b-471e-816f-ccb19465194a"), Feats.Instances.MountainStronghold.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b55ae14-6507-4b50-a709-91b1b724eaee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
