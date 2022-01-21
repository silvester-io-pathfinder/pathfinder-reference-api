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
    public class TouchOfTheSun : Template
    {
        public static readonly Guid ID = Guid.Parse("057818a4-6f8f-490e-b3d2-962eb7ea8c9d");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Touch of the Sun",
                Edicts = "Help others with changes that can improve their lives, mind those that others forget or exclude, offer second chances, stand up for others when they can't stand for themselves.",
                Anathema = "Challenge the sun, ignore the pleas of others when you are able to help, refuse to give someone else a chance to offer their truth.",
                
                AreasOfConcern = "Compassion, rebirth, and the sun.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("a07c0b7a-1ca8-40bd-9cb0-8bba0f4eda0a"), Type = TextBlockType.Text, Text = "Legends state thatChohar,Luhar, andTleharwere the first sun-kings of Mzali, building the city as a safe haven for the people of the Expanse. Their might, leadership, and kindness earned them a place among the heavens, transforming them into the sun gods of Mzali. As gods, they metSarenrae, another goddess of the sun, and for a time, all four worked together to help the people of Golarion. Eventually, whether intentionally or otherwise, the people of Mzali forgot their sun gods. The sun gods watched as the people of Mzali forgot prayers and songs to their former gods. The sun gods wept because their people could no longer see or hear them, but Sarenrae offered them words of encouragement: there would be a time when people remembered the sun gods once more." };
            yield return new TextBlock { Id = Guid.Parse("bf701fb0-483d-4dc6-850a-c1c056891537"), Type = TextBlockType.Text, Text = "Thanks to the efforts of the Bright Lions of Mzali, worship of the sun gods has returned to the Mwangi Expanse. While the sun gods appreciate this renewed faith, they did not forget Sarenrae's kindness. When asked about their disappearance, the sun gods merely state they were biding their time alongside a friend. This friendship led to the worship of the three sun gods alongside Sarenrae as a greater sun pantheon. The collective sun gods teach that kindness and second chances are pivotal values. They also note that sometimes a person needs to change into someone new before they are truly themselves and instruct that helping others with these changes is akin to helping bring new life into the world. The four gods know that there might be other forgotten gods and peoples out there that just need some kindness to make it through their period of turmoil, so they ask their worshippers to help these forgotten in whatever way they can. Finally, the sun gods make it clear that lost or abandoned gods can still find companionship among the divine and welcome these gods to join their ranks." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("2dbc1a44-5f6c-4eca-b98f-2986b9bb9b88"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("44cd1915-ae36-4ede-a375-8b31051bc70f"), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse("309af5f4-17cc-472e-af82-216bad62afbd"), Spells.Instances.FieryBody.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Rapier.ID;
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
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Sun.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("b592903b-3394-4419-bd84-bf6f64453749"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 0
            };
        }
    }
}
