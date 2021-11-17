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
    public class Kitumu : Template
    {
        public static readonly Guid ID = Guid.Parse("ce592160-0f34-48f3-9ece-f28c1b8c635f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Kitumu",
                Edicts = "Offer sacrifices to Kitumu, feed the hungers of nature with humanoid creatures.",
                Anathema = "Step on a firefly, kill those marked by Kitumu.",
                Title = "Mother of Fireflies",
                AreasOfConcern = "Fireflies, flames.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("3c8b8311-4f59-4492-a3c9-3d2da42afbdf"), Type = TextBlockType.Text, Text = "If any fervent devotees of the monstrous firefly goddess exist, they don't venture into civilization. The closest Kitumu has to servants or worshipers are those willing to placate the goddess in order to satisfy her demands and hungers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e2a5f15f-bf62-4bb2-88e0-6d62050862e6"), Spells.Instances.Sleep.ID);
            builder.GainSpecificSpell(Guid.Parse("465b7afa-4722-4396-bbdf-9494661a1871"), Spells.Instances.VomitSwarm.ID);
            builder.GainSpecificSpell(Guid.Parse("f2e33972-9956-4c13-a2c8-73d7e338fe66"), Spells.Instances.InsectForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Dagger.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Swarm.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad1beec1-39a8-4902-b3b4-3485aa672cf0"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 158
            };
        }
    }
}
