using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("aa8c5bd1-5c9b-4ac7-8cdf-19cad1f135ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duelist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the duelist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ec1436d-491f-4e78-bc71-c4196fd38d45"), Type = TextBlockType.Text, Text = "You are always ready to draw your weapon and begin a duel, no matter the circumstances. You gain the (feat: Quick Draw) ranger feat, enabling you to both draw and attack with a weapon as 1 action. This serves as (feat: Quick Draw) for the purpose of meeting prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("2b8f3516-f519-4a03-8f88-3d2a436e3b52"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("22471f42-c861-43f2-85a8-171edb51398e"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d3fd542-527a-48b5-b4db-36fe591e9276"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
