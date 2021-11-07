using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryNegotiation : Template
    {
        public static readonly Guid ID = Guid.Parse("a59daf85-0a42-46e1-af36-7748903b8b5d");

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
            yield return new TextBlock { Id = Guid.Parse("2e7c4ce2-1548-4464-98c2-d73fdf8f975e"), Type = TextBlockType.Text, Text = "You can negotiate incredibly quickly in adverse situations. You attempt to (action: Make an Impression) and then (action: Request) your opponent cease their current activity and engage in negotiations. You take a -5 penalty to your Diplomacy check. The GM sets the DC of the Request based on the circumstances – it’s generally at least a very hard DC of the creature’s level. Some creatures might simply refuse, and even those who agree to parley might ultimately find your arguments lacking and return to violence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("14e39f61-e305-4b4e-9209-db39940b14b3"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb85233a-e84c-40a8-8c1c-5674c662bc3a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
