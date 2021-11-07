using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ef77c5a0-39c0-4070-9614-5fbd38d0128b");

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
            yield return new TextBlock { Id = Guid.Parse("10c6673a-2bb1-4d6e-97d6-d945c7af821b"), Type = TextBlockType.Text, Text = "You are always ready to draw your weapon and begin a duel, no matter the circumstances. You gain the (feat: Quick Draw) ranger feat, enabling you to both draw and attack with a weapon as 1 action. This serves as (feat: Quick Draw) for the purpose of meeting prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("1ca5bb2b-9e00-4d39-9869-08a57ee26475"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Unarmored.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("84dbe1a9-7f5b-446f-a16a-78b71b628b84"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("708de53c-766b-4cca-b116-5d27754d54c7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
