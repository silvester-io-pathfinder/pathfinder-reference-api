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
    public class Urgathoa : Template
    {
        public static readonly Guid ID = Guid.Parse("4c9eb6d6-ea83-407b-940c-04d06b3e19a9");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Urgathoa",
                Edicts = "Become undead upon death, create or protect the undead, sate your appetites.",
                Anathema = "Deny your appetites, destroy undead, sacrifice your life.",
                Title = "Pallid Princess",
                AreasOfConcern = "Disease, gluttony, and undeath.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6ac8150d-bb44-4e87-8b4d-7010d9022353"), Type = TextBlockType.Text, Text = "The chosen of Urgathoa do not dread the flaws of mortal flesh, such as aging, disease, or even death, for so long as they indulge in excess above all else, their goddess offers eternal freedom from such fickle constraints. Urgathoa herself was once a mortal woman who challenged and rejected the tenets of deities whose followers expected mindless conformity, temperance, and restraint. Why would the gods craft Golarion into a near-endless buffet abundant with pleasures of the body and mind if the living weren't destined to feast from it? Urgathoa so loved satiating her life's appetites that in death, she spat in the face ofPharasma'sjudgment, murdered the psychopomp assigned to aid her transition to the afterlife, and tore herself from the Boneyard with a feat of will that not only returned her to the Material Plane but also transformed her into the first divine undead creature." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("130a55b1-99c5-4e73-a1c6-edd00c669cc8"), Spells.Instances.GoblinPox.ID);
            builder.GainSpecificSpell(Guid.Parse("d8cefec6-2f1f-4462-85c5-49836338b33b"), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse("317c8fd9-24d1-4624-8d20-d2a2d612aac5"), Spells.Instances.MaskOfTerror.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Scythe.ID;
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
                Id = Guid.Parse("ed0c5434-94ea-45b2-acce-5e889898070a"),
                Description = "Urgathoa interferes in mortal affairs to fuel her own self-gratification and obsession with observing new sensations.",
                MinorBoon = "You feast on the spoils of life and death. You gain the benefits of the irongut goblin heritage, regardless of your ancestry. If you already have this heritage, the circumstance bonus increases to +4.",
                ModerateBoon = "Urgathoa blesses you as one of her children. You gain negative healing.",
                MajorBoon = "When you contract contagions, you experience fever dreams filled with insight. Once afflicted with a disease, you gain the effects of foresight with yourself as the target until no longer afflicted with any disease.",
                MinorCurse = "You must overindulge or partake in forbidden feasts before you find yourself even remotely sated. You need to eat 20 times as much food as normal to avoid starvation, though you always feel hungry regardless of how much you eat. If you dine on the flesh and blood of sapient creatures, you need to eat only the normal amount of such meals and your hunger abates.",
                ModerateCurse = "Urgathoa cuts you off from positive energy without granting you the blessing of undeath. You are harmed by positive effects and don't recover Hit Points from them, as if you were an undead or had negative healing, but you are still harmed by negative effects as normal.",
                MajorCurse = "Urgathoa teaches you that pointless lives in slavery to death and morality are bound to end in tragedy. You develop an incurable wasting disease that leaves you clumsy 2, enfeebled 2, and unable to move except by Crawling. This disease never progresses further to kill you, but it passes to your friends and loved ones merely by sight, wasting them away unto death before your eyes and causing them to rise as undead to haunt you.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("8e54006c-f8dd-4283-8d73-8f0b02c5c96d"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 49
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Undeath.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("845cdec6-ed42-4d1c-bfa0-c4b1b7e9f737"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
