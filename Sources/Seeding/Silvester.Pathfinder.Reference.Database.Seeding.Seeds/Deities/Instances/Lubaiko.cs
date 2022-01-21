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
    public class Lubaiko : Template
    {
        public static readonly Guid ID = Guid.Parse("f4e20ff9-3c89-4320-8433-74eddceda8cb");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Lubaiko",
                Edicts = "Set fires, change the world, act with ambition or not at all.",
                Anathema = "Calm a crowd, douse a fire, sleep in the same place three nights in a row.",
                Title = "The Spark in the Dust",
                AreasOfConcern = "Wildfire, bad luck, inspiration, turmoil.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("769cc8ae-f294-44d6-bbd7-d05f55a699f8"), Type = TextBlockType.Text, Text = "Fires and explosions of all kinds are Lubaiko's passion, from an ember that ignites a flour mill to an outrage that rips through a nation. She is the powder keg whose fuse has burned down, erupting into something momentous, be it for better or for worse. Roaming throughout the sky above Golarion, she delights in throwing her bolts into the fields and the minds of people, whenever conditions permit and wherever they may fall. Some believe the smoke from Lubaiko's fires are curses and misfortune flying up into the air to spread throughout the land. Yet Lubaiko's blazes also often clear the way for new growth." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("631cd081-2c69-4133-abd0-2ce3e570ee9b"), Spells.Instances.IllOmen.ID);
            builder.GainSpecificSpell(Guid.Parse("7f68d7d6-ba43-4f33-ade8-8e2030cc0a6b"), Spells.Instances.FlamingSphere.ID);
            builder.GainSpecificSpell(Guid.Parse("ebe6a1a6-38b6-4a8e-9154-4c00c65c6995"), Spells.Instances.FieryBody.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Longspear.ID;
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
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Lightning.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("153755ee-c4e6-482e-845d-d19ced9a3429"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 138
            };
        }
    }
}