using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoblinJubileeDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("61c37351-b923-4d41-b724-44292828a863");

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
            yield return new TextBlock { Id = Guid.Parse("99322fb5-f090-483b-96be-6ac92137cbeb"), Type = TextBlockType.Text, Text = "Flames and explosions sear the air in a riot of color and devastation that rivals that wrought by even the wildest goblin party. The display is both so beautiful and chaotic that, while mesmerizing, it poses a significant risk to the physical health, sight, and hearing of anyone who gets too close. You gain the Goblin Jubilee fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("977d1f61-43aa-42ac-b3cb-c4de7481ccf2"), Type = TextBlockType.Text, Text = "~ Goblin Jubilee: THREE-ACTIONS ((trait: fire), (trait: sonic), (trait: visual)) **Cost** 3 batches of infused reagents; **Effect** Chaos fills a 20-foot burst within 120 feet. All creatures in the area takes 3d6 fire damage and 3d6 sonic damage and must attempt a Fortitude save. A goblin jubilee display costs 3 batches of infused reagents, rather than 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5221ea7b-d1e6-460f-acb8-6c9e75e7d708"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f9933f75-4327-4521-97e6-f0ca36d41a19"),
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
                Id = Guid.Parse("664f47ce-4ed9-4164-9216-ca767813fbef"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
