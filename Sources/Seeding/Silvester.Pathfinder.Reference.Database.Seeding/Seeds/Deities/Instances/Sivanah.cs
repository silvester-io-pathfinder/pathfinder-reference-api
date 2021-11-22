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
    public class Sivanah : Template
    {
        public static readonly Guid ID = Guid.Parse("68d315b0-4911-42aa-8599-c7a20c130774");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Sivanah",
                Edicts = "Show the beauty in illusions, pursue the nature of truth, respect the need for secrets.",
                Anathema = "Use illusions and shadows to harm another creature, reveal a secret you have sworn to keep.",
                Title = "The Seventh Veil",
                AreasOfConcern = "Illusions, mysteries, reflections, secrets.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("c94b8f52-5e74-4bda-a2fe-78ffac6a180e"), Type = TextBlockType.Text, Text = "No ancient record reveals the truth of Sivanah's origins; in fact, only recent documents record her existence at all. The Seventh Veil is widely regarded as the goddess of illusion magic, often portrayed as a figure disguised by seven veils. Legends state that each face underneath the first six of her seven veils is of a different ancestry—human, elf, halfling, gnome, anadi, and naga— but the seventh face is never shown, believed to mask the goddess's true form. Some theologians believe Sivanah hails from the Shadow Plane, though the goddess's true nature and form continue to be topics of debate. Even her female visage, while agreed upon by her followers, could likewise be an illusion. Her goals are hidden from even her most faithful, which some believe to have hampered the faith's growth and influence beyond the level of a cult." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("2b54aa0d-8d3b-4cd3-9470-1f10855c46f1"), Spells.Instances.IllusoryDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse("ee99152d-32dd-450f-b395-b3c1ea5c21a0"), Spells.Instances.Veil.ID);
            builder.GainSpecificSpell(Guid.Parse("fe624e1c-9835-4e3b-9003-d5fb86768140"), Spells.Instances.ShadowSiphon.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.BladedScarf.ID;
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
                Id = Guid.Parse("6826dd52-a892-4881-b6d6-f2f000cef9b8"),
                Description = "The Seventh Veil abhors the use of illusion to cause harm and detests anyone who discourages or corrupts the process of truth-seeking. The goddess works actively against the faith of Zon-Kuthon and his clerics' use of shadow. ",
                MinorBoon = "Sivanah prevents your enemies from pulling off your veil. Once, when a foe rolls a success on a Perception check to disbelieve your illusion, it gets a critical failure instead. Sivanah typically grants this benefit to protect an elaborate or consequential illusory deception, and she never uses it to improve the effect of a harmful illusion.",
                ModerateBoon = "You wear a veil of illusion wherever you go. You can cast illusory disguise at will as an innate divine spell.",
                MajorBoon = "You spread your illusions over a larger area. You can designate an area to permanently gain the effects of hallucinatory terrain. All creatures within this area gain the effects of illusory disguise, changing their forms as you wish. You can designate a new area as a 1-minute activity, but doing so dismisses any previously designated areas.",
                MinorCurse = "Your hair becomes a wild variety of colors, which cannot be altered with mundane or magical means, and it somehow grows out from under any cap, scarf, or other headwear intended to disguise it. You gain a –2 status penalty to Deception skill checks to Impersonate anyone else.",
                ModerateCurse = "Those who betray the secrets of others find their own secrets laid bare. Each person from whom you are keeping a secret immediately learns one of your secrets involving that person. This curse doesn't give away other people's secrets you are keeping, only your own.",
                MajorCurse = "Mirrors break whenever you cross their paths. You cannot be concealed by illusion magic of any kind (the spell automatically fails), and all creatures that see you know your true identity",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("ae5117e9-313f-4806-b2d3-ec8b5d68c2e2"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 9
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Delirium.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Trickery.ID;
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
                Id = Guid.Parse("2b2baff4-0fba-48df-84fb-f6b770b199ae"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 69
            };
        }
    }
}
