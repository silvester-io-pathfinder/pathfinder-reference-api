using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloudJump : Template
    {
        public static readonly Guid ID = Guid.Parse("2bd5b7ca-53af-4389-bea9-f5e66cf038e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cloud Jump",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a36e2689-c202-4f0f-82b9-c3c687410383"), Type = TextBlockType.Text, Text = "Your unparalleled athletic skill allows you to jump impossible distances. Triple the distance you (action: Long Jump) (so you could jump 60 feet on a successful DC 20 check). When you (action: High Jump), use the calculation for a (action: Long Jump) but don’t triple the distance." };
            yield return new TextBlock { Id = Guid.Parse("6e162e1a-7c90-4298-8d30-9bdad6fe47bd"), Type = TextBlockType.Text, Text = "You can jump a distance greater than your Speed by spending additional actions when you (action: Long Jump) or (action: High Jump). For each additional action spent, add your Speed to the limit on how far you can (action: Leap)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5a0c2ad2-6c24-4fb8-80b0-ab3ddccf4928"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1576d4f-be46-4162-916b-01ae499c3cb4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}