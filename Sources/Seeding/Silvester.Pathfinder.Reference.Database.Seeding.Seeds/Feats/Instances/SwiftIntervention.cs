using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwiftIntervention : Template
    {
        public static readonly Guid ID = Guid.Parse("eaad021d-6697-46e4-9882-fe35b61e47d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swift Intervention",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within your overwatch field fails in their attempt to Arrest a Fall, Balance, Grab a Ledge, or Maneuver in Flight.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9db6891-e8f2-4e5d-ada2-44d26416641b"), Type = TextBlockType.Text, Text = $"You're burdened with noticing potential threats at all times. Because of this, you've learned that a well-placed shot can prevent disaster. You make a shot to either pin an ally's clothing to stop a fall or secure them against a ledge, or you bounce an attack off their armor to correct their course as they stumble while attempting to balance or fly." };
            yield return new TextBlock { Id = Guid.Parse("e34847bf-2d8a-4076-9e34-dae667a3a808"), Type = TextBlockType.Text, Text = $"Make a single ranged attack roll against the DC of the triggering check; your ally uses the result of your ranged attack roll in place of their original roll. You must have line of effect to your ally, and your attack roll includes any normal bonuses or penalties for a ranged attack with that weapon (such as the penalty for making a ranged attack beyond your first range increment)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("31226c8e-4917-4d98-b4dc-7526d98a7775"), Feats.Instances.OverwatchDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1c6a76a-0bc4-455f-8dcf-f363599287db"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
