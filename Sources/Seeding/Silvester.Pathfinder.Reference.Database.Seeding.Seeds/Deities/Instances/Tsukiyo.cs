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
    public class Tsukiyo : Template
    {
        public static readonly Guid ID = Guid.Parse("40213fd4-39d6-41e1-b3c3-332ef83065f8");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.TianGods.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Tsukiyo",
                Edicts = "Provide aid and counsel without judgment to those who seek help, help the dead find their rest, amplify or help speak for the powerless and demonized.",
                Anathema = "Harm another out of envy, force aid on those who do not want it, inflict harmful mental effects on others as punishment.",
                Title = "Prince of the Moon",
                AreasOfConcern = "Jade, the moon, spirits.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("e18ffd45-aa25-4479-b8ee-61f6ecf0843d"), Type = TextBlockType.Text, Text = "The surface of Golarion's moon is marred with a great scar, and the people of Tian Xia say this is where Tsukiyo, the Prince of the Moon, was struck down by his envious brotherFumeiyoshi. When his loverShizurufound him the next morning, her tears mixed with his blood to create the first pieces of jade. Shizuru brought him toQi Zhong, the god of medicine, who resurrected him; but his experience on the other side changed him from a boisterous and carefree soul to a thoughtful and temperamental one. He now sees the world differently from most—something that has strained his relationships and made it difficult for him to relate to others, but has also allowed him to offer his understanding and quiet comfort to those who are lost, demonized, or misunderstood." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("7a6c4ded-6a71-488f-9e8a-445b8c46c185"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("cfe4f6cc-53e6-40e8-bf51-4c495653ea2d"), Spells.Instances.MirrorImage.ID);
            builder.GainSpecificSpell(Guid.Parse("ee0b4e15-721c-4b13-ab24-eaef627bf231"), Spells.Instances.Hallucination.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Spear.ID;
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
                Id = Guid.Parse("2c265ac6-376c-4c90-bd78-914c3ad0fc90"),
                Description = "Ever mercurial, the Prince of the Moon gives his blessings rarely and somewhat spontaneously. An understanding soul, he is as slow to curse as he is to bless.",
                MinorBoon = "Tsukiyo's simplest show of gratitude is a gift of clarity. Once, when you roll a failure on a saving throw against a mental effect, you get a critical success instead. Tsukiyo typically grants this boon against a particularly consequential mental effect.",
                ModerateBoon = "Tsukiyo watches over you and guards your sleep. You are guaranteed a peaceful night's rest no matter what conditions you are sleeping in. Even nightmare and similar abilities can't disrupt your sleep unless they come from a deity, artifact, or similarly powerful source.",
                MajorBoon = "Tsukiyo shares some of his own nature and can lead a favored soul back along the same path he has walked. The next time you would die, you are instead instantly restored to full health and lose any negative conditions you have.",
                MinorCurse = "Those who offend Tsukiyo find that light actively shuns them. You lose any low-light vision or darkvision you have, and you treat all light levels as one step lower.",
                ModerateCurse = "If Tsukiyo is particularly offended by someone, they may find themselves lost in delusions of moonlight. When attempting to navigate or find something at night, if you roll a success or critical success on your Perception check, Survival check, or other check to do so, you get a failure instead.",
                MajorCurse = "When Tsukiyo truly loses patience with someone, he forces them to experience the hardships of others firsthand. Whenever you touch another creature or another creature touches you, you immediately gain any negative curses, diseases, and conditions they are suffering. These effects spread to you even when you Strike another creature or a creature Strikes you.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("87b9caf5-b9a6-4975-ac9a-1a4b6d1545cf"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 9
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Delirium.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Repose.ID;
            yield return Domains.Instances.Soul.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f8c6fa2-b379-44cd-b53f-5e96a8a68afc"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 71
            };
        }
    }
}
