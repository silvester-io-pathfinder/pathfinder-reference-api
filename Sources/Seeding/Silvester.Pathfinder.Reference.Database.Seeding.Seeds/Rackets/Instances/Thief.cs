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
    public class Thief : Template
    {
        public static readonly Guid ID = Guid.Parse("294d627e-87b0-4967-afb2-a2eb67a6b75d");
        
        protected override Racket GetRacket()
        {
            return new Racket
            {
                Id = ID, 
                Name = "Thief",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ae59e2c4-ceaf-4420-88fc-2c1e70562b91"), Type = TextBlockType.Text, Text = "Nothing beats the thrill of taking something that belongs to someone else, especially if you can do so completely unnoticed. You might be a pickpocket working the streets, a cat burglar sneaking through windows and escaping via rooftops, or a safecracker breaking into carefully guarded vaults. You might even work as a consultant, testing clients� defenses by trying to steal something precious." };
            yield return new TextBlock { Id = Guid.Parse("713526ce-6318-4f00-abef-7881b9bcdf2e"), Type = TextBlockType.Text, Text = "When a fight breaks out, you prefer swift, lightweight weapons, and you strike where it hurts. When you attack with a finesse melee weapon, you can add your Dexterity modifier to damage rolls instead of your Strength modifier." };
            yield return new TextBlock { Id = Guid.Parse("2211405f-56c0-44ed-998f-7e4efd68eb98"), Type = TextBlockType.Text, Text = "You are trained in Thievery." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("f20fd088-8fdb-49d5-9265-3d46162c5a54"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22b87d68-76d2-4fa3-9b34-5812c4982b41"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 180
            };
        }
    }
}
