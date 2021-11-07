using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoblinJubileeDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("e58f7a70-895b-4918-b847-16cccd09990d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goblin Jubilee Display",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20be3f0a-c658-4bf4-b534-131bf36586f6"), Type = TextBlockType.Text, Text = "Flames and explosions sear the air in a riot of color and devastation that rivals that wrought by even the wildest goblin party. The display is both so beautiful and chaotic that, while mesmerizing, it poses a significant risk to the physical health, sight, and hearing of anyone who gets too close. You gain the Goblin Jubilee fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("a47e5f8c-6aa2-4da9-99f3-3908342b9512"), Type = TextBlockType.Text, Text = "~ Goblin Jubilee: THREE-ACTIONS ((trait: fire), (trait: sonic), (trait: visual)) **Cost** 3 batches of infused reagents; **Effect** Chaos fills a 20-foot burst within 120 feet. All creatures in the area takes 3d6 fire damage and 3d6 sonic damage and must attempt a Fortitude save. A goblin jubilee display costs 3 batches of infused reagents, rather than 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e1099b1c-688d-4074-b5c9-dfeffd7f284a"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("365d9bd7-71f8-4f7e-a3d3-d49bc980b572"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled and deafened until the end of its next turn and takes half damage.",
                Failure = "The creature is dazzled and deafened for 1 minute and takes full damage.",
                CriticalFailure = "The creature is blinded for 1 round, dazzled and deafened for 1 minute, and takes double damage.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c65f9fbb-20c9-4d37-ba31-e6cbc8b06436"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
