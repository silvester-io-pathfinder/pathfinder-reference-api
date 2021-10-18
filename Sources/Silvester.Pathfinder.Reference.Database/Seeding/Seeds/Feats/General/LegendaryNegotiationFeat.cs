using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryNegotiationFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("5803b272-2368-49ce-ba0b-8c97aa753885");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Negotiation",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be06ab53-d3f3-48bd-95b0-e5ed0ef51451"), Type = Utilities.Text.TextBlockType.Text, Text = "You can negotiate incredibly quickly in adverse situations. You attempt to Make an Impression and then Request your opponent cease their current activity and engage in negotiations. You take a –5 penalty to your Diplomacy check. The GM sets the DC of the Request based on the circumstances—it’s generally at least a very hard DC of the creature’s level. Some creatures might simply refuse, and even those who agree to parley might ultimately find your arguments lacking and return to violence." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("b2b79e69-4c97-4b1d-a48d-6fde4da02465"), RequiredSkillId = Skills.Instances.Diplomacy.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
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
                Id = Guid.Parse("ff6f8fb3-9477-449b-b5ce-bd2680474617"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
