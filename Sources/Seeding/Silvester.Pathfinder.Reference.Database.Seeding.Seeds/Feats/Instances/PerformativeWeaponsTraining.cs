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
    public class PerformativeWeaponsTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("a16d4eab-8730-496f-a9b7-4466cb4044e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Performative Weapons Training",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7697237-cd75-452d-81cc-0388bf15125a"), Type = TextBlockType.Text, Text = $"You're skilled with flashy weapons. You are trained with the {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("bo staff", Items.MeleeWeapons.Instances.BoStaff.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("dueling cape", Items.AdventuringGears.Instances.DuelingCape.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("spiked chain", Items.MeleeWeapons.Instances.SpikedChain.ID)}, {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("sword cane", Items.MeleeWeapons.Instances.SwordCane.ID)}, and {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("whip", Items.MeleeWeapons.Instances.Whip.ID)}. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the weapons listed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("663d5bb6-8d73-4f18-89de-9dcf364d3bb8"), Feats.Instances.GladiatorDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bf3db04-09eb-497d-8fa0-96e6990a319c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
