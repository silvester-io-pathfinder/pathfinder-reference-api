using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystalWardSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("de66b433-d786-4353-b907-6c6f11a5b671");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crystal Ward Spells",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f88b007-1c25-480f-b553-3405d6f31bb4"), Type = TextBlockType.Text, Text = "Your study of crystals and the energies held within a gem's facets grants you special arcane crystal ward spells, which are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool when you make your next daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the (action: Refocus) activity to research and memorize the properties of gems." };
            yield return new TextBlock { Id = Guid.Parse("7858e82b-bfa0-46e1-a87c-3e1e5f64e3d9"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. You gain the (spell: electrified crystal ward) focus spell, and you are trained in arcane spell attack rolls and spell DCs. Your spellcasting ability is Intelligence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9fe2f3ae-b527-427e-8afd-4ad0132feca3"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("425e4ced-29ab-47e2-afab-50547bb9d455"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
