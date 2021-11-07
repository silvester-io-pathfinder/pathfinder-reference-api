using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GladiatorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("82fa88a4-a30c-4c72-a82a-01b91b36a2c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gladiator Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the gladiator archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac74eb0d-b249-4b5c-8cfc-f9f966599271"), Type = TextBlockType.Text, Text = "You know how to turn combat into a form of entertainment. You become trained in Gladiatorial Lore; if already trained in Gladiatorial Lore, you instead become trained in another Lore skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("22b3c866-71e8-4175-aae2-7c89b437a522"), Type = TextBlockType.Text, Text = "At the start of a combat encounter, if you have spectators, you gain a number of temporary HP equal to your character level for 1 minute and you can roll Performance for your initiative." };
            yield return new TextBlock { Id = Guid.Parse("97113be6-52db-4578-bee4-2423eec8351f"), Type = TextBlockType.Text, Text = "If there are sapient creatures observing a combat encounter, and these onlookers are neither engaged in the combat themselves nor allied or affiliated with either side, the combatants have spectators. The GM is the final arbiter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eb93346c-37d7-4bd5-a7d2-d380c083b02e"), Feats.Instances.ImpressibePerformance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d161a621-694e-4d11-bf14-3aaee0474500"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
