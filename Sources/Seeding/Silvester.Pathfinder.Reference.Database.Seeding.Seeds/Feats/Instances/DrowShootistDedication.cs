using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrowShootistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("66334567-b4d7-450b-81d4-fbde3d3f36d8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drow Shootist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the drow shootist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b160b526-89ab-45ee-ba25-f7095838dbd2"), Type = TextBlockType.Text, Text = $"Every chance you get, you practice with the hand crossbow to increase your draw speed and accuracy. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbow", Items.RangedWeapons.Instances.HandCrossbow.ID)}. If you're at least an expert in a {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbow", Items.RangedWeapons.Instances.HandCrossbow.ID)} you're using, you gain access to its critical specialization effect. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Shootist's Draw", Feats.Instances.ShootistsDraw.ID)} action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRangedWeaponSpecificProficiency(Guid.Parse("c1ce4853-c1f8-4d61-ae8f-f953abbdccfb"), Proficiencies.Instances.Trained.ID, Items.RangedWeapons.Instances.HandCrossbow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b800bd54-fe37-45d4-b7b9-299abbf0984f"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
