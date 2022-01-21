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
    public class Isis : Template
    {
        public static readonly Guid ID = Guid.Parse("a097bc59-5352-4668-88ba-8a4086be4f31");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.AncientOsirianGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Isis",
                Edicts = "Provide aid to the sick and wounded, use magic to help others, mourn the cherished dead, ritually purify yourself before entering sacred areas.",
                Anathema = "Reveal sacred rites to the uninitiated, betray your children or your lover, discriminate based on social status.",
                Title = "Queen of Miracles",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e4ec9227-a23f-465c-9b35-599b0e774cb1"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("970be0a1-bb5b-4593-ab87-2be5698809e5"), Spells.Instances.HumanoidForm.ID);
            builder.GainSpecificSpell(Guid.Parse("afc80507-80b7-46b2-8cd2-baee5412967d"), Spells.Instances.AnimalVision.ID);
            builder.GainSpecificSpell(Guid.Parse("03f5cf58-0e20-49eb-9d8f-96ac9f17c5fa"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("7bfed4f9-739d-488c-ae27-a28ed99a77b3"), Spells.Instances.ControlWater.ID);
            builder.GainSpecificSpell(Guid.Parse("57c61325-04df-4505-869a-4831a524437b"), Spells.Instances.WallOfForce.ID);
            builder.GainSpecificSpell(Guid.Parse("51b76f28-3f7f-4a72-897e-f04df404b2f1"), Spells.Instances.MagnificentMansion.ID);
            builder.GainSpecificSpell(Guid.Parse("1c74a92d-32e8-42d4-a09e-e6abc8ddb4d4"), Spells.Instances.WindWalk.ID);
            builder.GainSpecificSpell(Guid.Parse("2fdf0003-26dc-4562-b411-522a7cfd748a"), Spells.Instances.Shapechange.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Staff.ID;
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
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Passion.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b6ca76b-676d-4ebb-81cd-c242d4fb4196"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
