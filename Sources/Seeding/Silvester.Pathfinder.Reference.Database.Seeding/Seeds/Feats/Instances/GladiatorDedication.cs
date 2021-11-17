using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GladiatorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("3906c498-afe1-4437-bc7a-c82637d94664");

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
            yield return new TextBlock { Id = Guid.Parse("9a00d674-645e-475b-b0fa-6287ba178a4a"), Type = TextBlockType.Text, Text = "You know how to turn combat into a form of entertainment. You become trained in Gladiatorial Lore; if already trained in Gladiatorial Lore, you instead become trained in another Lore skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("828a6115-b7c4-4fbd-a259-3d2167d9edb5"), Type = TextBlockType.Text, Text = "At the start of a combat encounter, if you have spectators, you gain a number of temporary HP equal to your character level for 1 minute and you can roll Performance for your initiative." };
            yield return new TextBlock { Id = Guid.Parse("ec0054f5-5331-450a-80df-7d2ec0406f53"), Type = TextBlockType.Text, Text = "If there are sapient creatures observing a combat encounter, and these onlookers are neither engaged in the combat themselves nor allied or affiliated with either side, the combatants have spectators. The GM is the final arbiter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d0ca338c-a3a1-4762-bb4f-fe69a4a861e2"), Feats.Instances.ImpressivePerformance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2d3ecd7-cd82-4426-b0ff-2232f041b319"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}