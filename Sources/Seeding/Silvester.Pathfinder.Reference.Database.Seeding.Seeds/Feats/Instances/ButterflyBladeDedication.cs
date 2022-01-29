using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ButterflyBladeDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("46379bc9-64a3-43c2-985d-0a9a2817ac7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Butterfly Blade Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef8a4faf-653f-4ea2-b882-555ae7869b47"), Type = TextBlockType.Text, Text = $"You become trained in Deception and Stealth; if you were already trained, you become an expert instead. Whenever your proficiency rank in any weapon increases to expert or beyond, you also gain that new proficiency rank with butterfly swords. You gain access to {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("butterfly swords", Items.MeleeWeapons.Instances.ButterflySword.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("527c032b-b451-4841-aff3-6728c0f2d368"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.ButterflySword.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94759055-e731-4665-83a6-a0c25a36fdb7"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
