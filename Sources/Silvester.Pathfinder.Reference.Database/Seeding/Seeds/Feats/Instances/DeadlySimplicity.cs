using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlySimplicity : Template
    {
        public static readonly Guid ID = Guid.Parse("53e082ee-0a06-44a6-9104-51b793e8f513");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Simplicity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef604b25-a5ed-4633-8603-682364f215e0"), Type = TextBlockType.Text, Text = "Your deity’s weapon is especially powerful in your hands. When you are wielding your deity’s favored weapon, increase the damage die size of that weapon by one step." };
            yield return new TextBlock { Id = Guid.Parse("77bb3b54-d599-419f-839d-7274e9e3a784"), Type = TextBlockType.Text, Text = "If your deity’s favored weapon is an unarmed attack (such as a fist, if you worship Irori) and its damage die is smaller than d6, instead increase its damage die size to d6." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("609b3da5-8ca8-46c7-a35c-f2cf38b95ddf"), or => 
            {
                or.HaveAnyDeitySpecificWeaponCategory(Guid.Parse("d68cabd0-1f51-4e8a-a613-7c14f1535a19"), WeaponCategories.Instances.Simple.ID);
                or.HaveAnyDeitySpecificWeaponCategory(Guid.Parse("b01621fa-b419-4ca7-8cb5-71d41055ef0d"), WeaponCategories.Instances.Unarmed.ID);
            });
            builder.HaveFavoredWeaponSpecificProficiency(Guid.Parse("04bf7062-2802-433c-9f76-af569de55445"), Proficiencies.Instances.Trained.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d362cd6b-1da6-43f0-b877-b4f44c096fba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
