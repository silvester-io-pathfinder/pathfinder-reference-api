using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryNegotiation : Template
    {
        public static readonly Guid ID = Guid.Parse("685b1aab-96dc-4112-ba9d-ef874175be5e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Negotiation",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5eaabddb-c8a6-4b24-9e77-cb8f14dfc403"), Type = TextBlockType.Text, Text = $"You can negotiate incredibly quickly in adverse situations. You attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} and then {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} your opponent cease their current activity and engage in negotiations. You take a -5 penalty to your Diplomacy check. The GM sets the DC of the Request based on the circumstances – it's generally at least a very hard DC of the creature's level. Some creatures might simply refuse, and even those who agree to parley might ultimately find your arguments lacking and return to violence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("29aa40f3-c5fd-45eb-91e7-ab8f01a7fc64"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("781a283a-76f8-49e4-9c19-339a66f0755d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
