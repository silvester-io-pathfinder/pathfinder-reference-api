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
    public class PillarsOfKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("3d7a9a02-801d-48af-9b0c-221cb2914515");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Pillars of Knowledge",
                Edicts = "Seek new knowledge, use your knowledge and skill to improve the world around you, protect knowledge from becoming lost.",
                Anathema = "Choose to use old knowledge or tools after they have been improved upon, destroy knowledge, refuse to answer a query for which you know the answer.",
                
                AreasOfConcern = "Learning, innovation, safeguarding knowledge.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("02e38190-451a-45ec-b14f-0ef1bff49d3c"), Spells.Instances.MessageRune.ID);
            builder.GainSpecificSpell(Guid.Parse("bf5129b0-2a0d-4d13-be05-c8d25464e2e8"), Spells.Instances.Hypercognition.ID);
            builder.GainSpecificSpell(Guid.Parse("02fcc955-2c9b-4f79-a92a-2c82357a7ff0"), Spells.Instances.Retrocognition.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.LightHammer.ID;
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
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("34fc946d-b43b-4871-b11b-fb10f51688d3"),
                SourceId = Sources.Instances.FriendsInHighPlaces.ID,
                Page = 1
            };
        }
    }
}
