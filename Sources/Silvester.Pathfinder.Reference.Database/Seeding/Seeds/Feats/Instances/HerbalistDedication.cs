using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HerbalistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("348a8eeb-23f2-4ab6-a9c7-6d6b63336950");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Herbalist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the herbalist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("878f5532-06fe-4620-a5d9-c15e07e5fc90"), Type = TextBlockType.Text, Text = "You can create remedies and other herbal products. You gain the alchemist’s infused reagents class feature, gaining a number of reagents each day equal to your level or half your level if you didn’t make your daily preparations in the wilderness. Your advanced alchemy level for creating these is 1 and doesn’t increase on its own. You also gain the (feat: Alchemical Crafting) feat. You may only create and choose formulas for herbal items: alchemical items with the (trait: healing) trait, plus (item: antidote | Antidote lesser) and (item: antiplague | Antiplague lesser)." };
            yield return new TextBlock { Id = Guid.Parse("061a4fb6-420e-4da8-a061-65bfb73aa228"), Type = TextBlockType.Text, Text = "You become an expert in Nature and can use Nature instead of Crafting to (action: Craft) herbal items. You don’t need to be trained in Crafting and you can use (item: healer’s tools) instead of (item: alchemist’s tools)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8b36b1b6-8729-41bb-8c2d-51ab1e5cf27d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("d5312b11-a891-4fe1-991a-1dfcc8b21923"), Feats.Instances.NaturalMedicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8058294f-5c38-463e-81f6-19aa9f073305"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
