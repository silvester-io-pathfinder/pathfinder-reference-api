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
    public class FireworkTechnicianDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("328a9fa6-5529-445e-9504-44be86f0687d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Firework Technician Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the fireworks technician archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3f2e669-dfe8-4a1b-8c75-2600f54db5b1"), Type = TextBlockType.Text, Text = $"You've learned the secrets of making fire and sound bloom using black powder, metals, and paper. You most likely came by this knowledge through formal training with a fireworks house in Tian Xia or a fireworks company from Vudra, though perhaps you mastered fireworks completely by yourself after finding a secret stash in an old shipwreck." };
            yield return new TextBlock { Id = Guid.Parse("52010e5e-1589-4534-972a-a4e085236ddb"), Type = TextBlockType.Text, Text = $"You become trained in Fireworks Lore or become an expert if you were already trained in it. You gain the {ToMarkdownLink<Models.Entities.Feat>("Alchemical Crafting", Feats.Instances.AlchemicalCrafting.ID)} feat, a pool of infused reagents equal to your level, and advanced alchemy (allowing you to make alchemical items during your daily preparations without the normal cost or time expenditure). You can use your infused reagents only to make fireworks, {ToMarkdownLink<Models.Entities.Feat>("Launch a Fireworks Display", Feats.Instances.LaunchFireworksDisplay.ID)}, and use other feats from this archetype. Your advanced alchemy level is 1. The rules for these are in the Alchemical Crafting section on page 258 of the Core Rulebook, and rules for infused reagents and advanced alchemy are on page 72. If you gain infused reagents from more than one source, you use the highest number of reagents to determine your pool rather than adding them together." };
            yield return new TextBlock { Id = Guid.Parse("0a3657b4-31bc-451d-969d-5bb37e57c61e"), Type = TextBlockType.Text, Text = $"You can also create special fireworks displays using your infused reagents, designed to create distinctive effects you can use to make onlookers marvel and even to gain an advantage in combat. You gain the {ToMarkdownLink<Models.Entities.Feat>("Launch Fireworks Display", Feats.Instances.LaunchFireworksDisplay.ID)} action and learn some basic displays, and you can learn additional, more complex displays through other firework technician feats. The DC for any display is equal to your class DC or spell DC, whichever is higher." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9e579056-df35-4374-97e9-f2a51eaa4fb7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("33842557-9102-40ff-92c7-ec729a2c9c8a"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("0bc83172-284b-4fcf-ae1b-6adf15c067ec"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01d34a97-8ac4-4b10-8172-2fba7d05564a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
