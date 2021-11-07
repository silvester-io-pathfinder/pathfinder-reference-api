using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterfulCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("13326d90-37df-4d4e-9c59-0462510f4c70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Masterful Companion",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f06ee6a2-88dc-4e60-a66d-e6749958feac"), Type = TextBlockType.Text, Text = "Your animal companion shares your incredible hunting skills, allowing it to take down your shared prey with ease. When you (feat: Hunt Prey), your animal companion gains the masterful hunter benefit associated with your hunter’s edge, rather than just your original hunter’s edge benefit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("29bf02ca-9f8e-4dc9-8546-78050e3b7a8b"), ClassFeatures.Rangers.MasterfulHunter.ID);
            builder.HaveAnyAnimalCompanion(Guid.Parse("e45ae095-7115-42a6-aea7-a573d675f439"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98f18aa3-16f7-4582-8329-44c5048eb506"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
