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
    public class Iomedae : Template
    {
        public static readonly Guid ID = Guid.Parse("504261bb-dcbf-43a2-8a0c-cbdd58c8b8da");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Iomedae",
                Edicts = "Be temperate, fight for justice and honor, hold valor in your heart.",
                Anathema = "Abandon a companion in need, dishonor yourself, refuse a challenge from an equal.",
                Title = "The Inheritor",
                AreasOfConcern = "Honor, justice, rulership, and valor.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("f752b896-e0c1-41dc-afe1-2c3de5877d06"), Type = TextBlockType.Text, Text = "Iomedae, the youngest among the prominent deities of the Inner Sea region, had already proven herself worthy of divinity before her ascension. Born in Cheliax, she followed the path of the sword and fought evil, eventually becoming a paladin of Aroden's heraldArazni. She became a legend among the Shining Crusade, leading the Knights of Ozem in a series of victories over the Whispering Tyrant. Iomedae became the third known mortal to pass the Test of the Starstone when she ascended to divinity in 3832 AR. As Arazni had been slain during the Shining Crusade, Aroden elevated the newly ascended goddess to be his new herald. When Aroden himself died, Iomedae inherited most of his worshippers and became a major deity of honor and justice." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("297de6ec-4430-412e-bd5c-25ec8719b7ae"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("c767dc80-7a3d-4154-b7bb-8afd9167a92d"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("c2ecb94a-7c5b-4614-a502-74cab8c63e79"), Spells.Instances.FireShield.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Longsword.ID;
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
                Id = Guid.Parse("a8151f15-a9a2-4e4b-a173-5afd3b77e0fc"),
                Description = "Iomedae grants her blessings to those who show valor in trying times.",
                MinorBoon = "You always present yourself at your best. Your clothing and person are always clean and unrumpled, the metal of your blade and armor shining and unblemished. This doesn't prevent you from being exposed to diseases and other afflictions via filth, but it protects you as well as if you had washed thoroughly right away.",
                ModerateBoon = "Your heart beats with a determined valor. Once, Iomedae ends all negative effects affecting you, unless they are from an artifact, deity, or similarly powerful source; she also restores all lost Hit Points and replenishes your spells, Focus Points, and other daily resources.",
                MajorBoon = "Iomedae imbues your blade with great power. Longswords you wield gain the axiomatic, holy, and major striking runes while you hold them. These property runes count toward the number of runes you can have on your weapon, and if this would cause your weapon to exceed its limit, choose which ones to keep each day when you prepare. You gain a +2 status bonus to attack rolls with longswords.",
                MinorCurse = "Your blade and armor have dulled like lead. Your weapons, armor, and shields have half their usual Hit Points and Break Threshold.",
                ModerateCurse = "Tactical advantages never seem to work the way you planned. You can't receive a circumstance bonus to your attack rolls, and enemies don't take any circumstance penalties to their AC against your attacks.",
                MajorCurse = "All blades reject your wicked heart. Any weapon you wield automatically becomes broken after you Strike with it. This curse can't break artifacts or similarly powerful weapons.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("46d37284-3750-4469-bf79-b10d1119f53d"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 29
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Truth.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("1af7990c-c270-4a17-b4b0-81b0ed8a9456"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
