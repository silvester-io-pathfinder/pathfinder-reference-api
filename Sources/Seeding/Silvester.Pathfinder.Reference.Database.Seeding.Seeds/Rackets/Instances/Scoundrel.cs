using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets.Instances
{
    public class Scoundrel : Template
    {
        public static readonly Guid ID = Guid.Parse("562bbb5f-5a8d-4418-9906-34ba2882104a");
        
        protected override Racket GetRacket()
        {
            return new Racket
            {
                Id = ID, 
                Name = "Scoundrel",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d39064fe-b44c-4c4a-b095-e32336c98317"), Type = TextBlockType.Text, Text = "You use fast-talking, flattery, and a silver tongue to avoid danger and escape tricky situations. You might be a grifter or con artist, traveling from place to place with a new story or scheme. Your racket is also ideal for certain reputable professions, like barrister, diplomat, or politician." };
            yield return new TextBlock { Id = Guid.Parse("84591aca-ce78-4550-a4f6-62d28a93812f"), Type = TextBlockType.Text, Text = "When you successfully Feint, the target is flat-footed against melee attacks you attempt against it until the end of your next turn. On a critical success, the target is flat-footed against all melee attacks until the end of your next turn, not just yours." };
            yield return new TextBlock { Id = Guid.Parse("9bdaf08d-626c-4417-b620-d4a90ebc8c58"), Type = TextBlockType.Text, Text = "You�re trained in Deception and Diplomacy. You can choose Charisma as your key ability score." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("0e628f31-2095-4f40-a5b3-0a5f670dca3f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("20dc0915-32a2-47ee-b2e5-4423f533a588"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("2f929fbe-1574-42cb-99da-e9a23d210f95"), Stats.Instances.Charisma.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96e0d267-d92e-483f-b008-a58d08c5ced1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 180
            };
        }
    }
}
