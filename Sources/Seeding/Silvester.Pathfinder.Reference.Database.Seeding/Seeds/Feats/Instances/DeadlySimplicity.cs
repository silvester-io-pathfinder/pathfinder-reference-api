using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlySimplicity : Template
    {
        public static readonly Guid ID = Guid.Parse("da76ade4-28f3-427d-b729-edde0988d9aa");

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
            yield return new TextBlock { Id = Guid.Parse("81eed2c4-d305-48eb-a625-d5f0dd893e26"), Type = TextBlockType.Text, Text = "Your deity’s weapon is especially powerful in your hands. When you are wielding your deity’s favored weapon, increase the damage die size of that weapon by one step." };
            yield return new TextBlock { Id = Guid.Parse("b2cab529-3f86-46c8-bc68-0e5f06d181ce"), Type = TextBlockType.Text, Text = "If your deity’s favored weapon is an unarmed attack (such as a fist, if you worship Irori) and its damage die is smaller than d6, instead increase its damage die size to d6." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("df511a87-94af-46ee-b28a-36e70291cd54"), or => 
            {
                or.HaveAnyDeitySpecificWeaponCategory(Guid.Parse("beda7bbb-7b8e-45b1-8916-6e8c24ef9201"), WeaponCategories.Instances.Simple.ID);
                or.HaveAnyDeitySpecificWeaponCategory(Guid.Parse("77dd310f-5ca4-4649-9129-471a076294a7"), WeaponCategories.Instances.Unarmed.ID);
            });
            builder.HaveFavoredWeaponSpecificProficiency(Guid.Parse("23d4cbdb-78e4-4fa8-a77e-bd56b4ae5087"), Proficiencies.Instances.Trained.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1310e7a6-4281-471d-a15a-e144e7f15a31"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
