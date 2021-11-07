using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterfulCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("29f6bce9-cbe1-4fad-8d37-db6bf659d2c3");

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
            yield return new TextBlock { Id = Guid.Parse("dbdffb71-7a70-4a9b-bcb4-1c1bc7178f55"), Type = TextBlockType.Text, Text = "Your animal companion shares your incredible hunting skills, allowing it to take down your shared prey with ease. When you (feat: Hunt Prey), your animal companion gains the masterful hunter benefit associated with your hunter’s edge, rather than just your original hunter’s edge benefit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1c0d8755-66c9-4f1d-a2d7-f66364e3137c"), Feats.Instances.MasterfulHunter.ID);
            builder.HaveAnyAnimalCompanion(Guid.Parse("58d9bce4-af00-4986-b268-6848d0905ec7"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f1205c2-51b1-4c01-9881-7f33220155ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
