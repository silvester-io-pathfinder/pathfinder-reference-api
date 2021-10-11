using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ImproviseToolFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8c05b082-0457-41f6-8c6d-684939c97664");


        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvise Tool",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f754c420-ca9e-45b3-821b-0d32749316c4"), Type = TextBlockType.Text, Text = "You can jury-rig solutions when you don't have the proper tools on hand. You can attempt to Repair damaged items without a repair kit." };
            yield return new TextBlock { Id = Guid.Parse("d5efa4cc-9584-4268-a20d-73f5eb6d4193"), Type = TextBlockType.Text, Text = "If you have the raw materials available, you can Craft a basic caltrop set, candle, compass, crowbar, fishing tackle, flint and steel, hammer, ladder, piton, rope, 10-foot pole, replacement thieves' picks, long or short tool, or torch without consulting a basic crafter's book." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("95cf0f88-4ff1-479d-a75d-5530f3824235"), RequiredSkillId = Skills.Instances.Crafting.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("434d1947-bb7e-424f-8dd2-6e04ef76f553"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 206
            };
        }
    }
}
