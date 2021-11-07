using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AccursedClayFist : Template
    {
        public static readonly Guid ID = Guid.Parse("09c5cb18-3327-485c-9e08-4524c73425f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accursed Clay Fist",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "The damage die for your clay fist is 1d8, and it loses the agile and finesse traits of a typical fist.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33f88848-f6ab-4fdf-8512-744b40d0c48d"), Type = TextBlockType.Text, Text = "You have replaced one of your forearms with one made of clay and infused with cursed arcane magic. When you make an unarmed (action: Strike) with your clay fist and hit, your target takes a -2 status penalty to saving throws against (trait: curse) effects for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7b1f7e69-1123-4773-9dab-29a4beb6265b"), Feats.Instances.GolemGrafterDedication.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("941d6b3c-cffd-4cd1-9c62-415027812896"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03e1e025-a8c8-4dae-99ab-220cc8ec95b6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
