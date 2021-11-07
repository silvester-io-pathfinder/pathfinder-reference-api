using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwiftIntervention : Template
    {
        public static readonly Guid ID = Guid.Parse("47edda85-2417-4c0f-b522-20c0818fca86");

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
            yield return new TextBlock { Id = Guid.Parse("6603c80e-1e8e-4329-aea8-267e08b70529"), Type = TextBlockType.Text, Text = "You’re burdened with noticing potential threats at all times. Because of this, you’ve learned that a well-placed shot can prevent disaster. You make a shot to either pin an ally’s clothing to stop a fall or secure them against a ledge, or you bounce an attack off their armor to correct their course as they stumble while attempting to balance or fly." };
            yield return new TextBlock { Id = Guid.Parse("ecfa07ec-f8df-4374-a39b-48cecf58a431"), Type = TextBlockType.Text, Text = "Make a single ranged attack roll against the DC of the triggering check; your ally uses the result of your ranged attack roll in place of their original roll. You must have line of effect to your ally, and your attack roll includes any normal bonuses or penalties for a ranged attack with that weapon (such as the penalty for making a ranged attack beyond your first range increment)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fcfdba08-43e8-4128-a6ed-a4babd887f5d"), Feats.Instances.OverwatchDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("430d4e47-4177-4596-8971-a2300eab2788"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
