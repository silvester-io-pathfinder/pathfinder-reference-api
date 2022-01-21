using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Gozreh : Template
    {
        public static readonly Guid ID = Guid.Parse("b5d8a0bb-3af4-4bbf-ba52-852c6f50f802");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Gozreh",
                Edicts = "Cherish, protect, and respect nature in all its forms.",
                Anathema = "Bring civilization to intrude on the wild, create undead, despoil areas of natural beauty.",
                Title = "The Wind and the Waves",
                AreasOfConcern = "Nature, the sea, and weather.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("9281c81b-69e8-4cff-9184-f4635a949ce2"), Type = TextBlockType.Text, Text = "A timeless entity birthed from the first wind to stir the vast oceans, Gozreh wanders the world in the air and the seas. Sailors drop boxes of cargo as offerings to avoid a fatal storm, hoping to please the Wind and the Waves, even though they know that such pleas are far more likely to go unnoticed as they are to draw their deity's attention. The deity's temperament is fickle and their fury swift, hurling bolts of lightning and dragging to the crushing depths those who dare befoul the natural world. Gozreh is the sea that encapsulates the land and the wind that moves its surface, the birds that traverse the sky and the clouds that shield them." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("9f27f914-ed80-4f62-b075-6804abbd887e"), Spells.Instances.GustOfWind.ID);
            builder.GainSpecificSpell(Guid.Parse("fbf22fac-05b8-471a-b6e9-d37795c510ac"), Spells.Instances.LightningBolt.ID);
            builder.GainSpecificSpell(Guid.Parse("b67d66e1-cb82-4168-9622-039304aa413a"), Spells.Instances.ControlWater.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Trident.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse("a2340ff9-a533-4c7e-a233-cbeddc2c13dd"),
                Description = "Gozreh is pleased when their creatures and waterways are treated with respect but quick to show their displeasure.",
                MinorBoon = "Gozreh grants their guidance while at sea. You are under the constant effects of know direction and become trained in Sailing Lore (or another Lore skill if you are already trained in Sailing Lore).",
                ModerateBoon = "You gain the touch of the sea. You can breathe underwater and gain a swim Speed equal to your land Speed.",
                MajorBoon = "Gozreh has blessed you with their wind in your stride. You gain a +30-foot status bonus to your Speeds, and you gain a fly Speed equal to your land Speed.",
                MinorCurse = "Lightning begins to strike twice. You gain weakness 5 to electricity, and any natural or magical bolts of lightning always target you rather than the other creatures around you.",
                ModerateCurse = "The current of the waves constantly fights against you, putting you at risk of drowning any time you must Swim. You lose any swim Speed you have, unless it's your only Speed, in which case you take a –20-foot status penalty to your swim Speed. When you roll an Athletics check to Swim, you always use the outcome for one degree of success worse than the result of your roll.",
                MajorCurse = "Those who displease Gozreh are shunned by nature itself. All animals and nonsapient plant creatures are hostile to you, and any animal companion or familiar abandons you. Sapient plants' attitude toward you begins two categories worse than normal, as something about you seems repugnant to them. While plants and animals might not attack you outright if it's not normally in their nature to do so when they are hostile, dogs growl at you, cats hiss, and so on.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("679d6da9-b56c-460e-84c7-e2bae5a40993"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 27
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("590c1af0-523d-4817-b0c2-d7ba9e1a721d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
