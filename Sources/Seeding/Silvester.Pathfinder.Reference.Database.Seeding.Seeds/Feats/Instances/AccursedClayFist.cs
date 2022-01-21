using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AccursedClayFist : Template
    {
        public static readonly Guid ID = Guid.Parse("282e1efc-71d1-453e-9006-cc417e7452a5");

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
            yield return new TextBlock { Id = Guid.Parse("8e778d3a-4af4-45ce-805d-ef1a158ce540"), Type = TextBlockType.Text, Text = $"You have replaced one of your forearms with one made of clay and infused with cursed arcane magic. When you make an unarmed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your clay fist and hit, your target takes a -2 status penalty to saving throws against {ToMarkdownLink<Models.Entities.Trait>("curse", Traits.Instances.Curse.ID)} effects for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1f967d54-1ce7-49c9-ac14-3625180080aa"), Feats.Instances.GolemGrafterDedication.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("b0b1d17b-7b15-4d17-ace7-89a394301f0e"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e501f082-806f-4387-83ec-c4b27794b5ac"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
