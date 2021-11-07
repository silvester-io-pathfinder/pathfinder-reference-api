using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyAim : Template
    {
        public static readonly Guid ID = Guid.Parse("3d9e93f8-25b1-4be8-b10e-a43e7e52bb7d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Aim",
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
            yield return new TextBlock { Id = Guid.Parse("c8795dd0-013f-4ee9-9259-7f14d4b1373c"), Type = TextBlockType.Text, Text = "You aim for your prey’s weak spots, making your shot more challenging but dealing more damage if you hit. Make a ranged (action: Strike) against your hunted prey at a -2 penalty. You gain a +4 circumstance bonus to damage on that (action: Strike). This bonus increases to +6 at 11th level and +8 at 15th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("43585cfe-b745-430f-a459-0d0b53dcab8e"), ClassFeatures.TODO.WeaponSpecialization.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a5aadf6-5262-4e91-8497-66885a009c2d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
