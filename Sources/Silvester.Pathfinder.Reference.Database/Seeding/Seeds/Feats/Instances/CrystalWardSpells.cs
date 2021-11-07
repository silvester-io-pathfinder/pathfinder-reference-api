using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystalWardSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("0fa64111-89e8-465b-9cd3-e863817b4b91");

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
            yield return new TextBlock { Id = Guid.Parse("443e117b-56f5-4191-b935-12ce9eff9125"), Type = TextBlockType.Text, Text = "Your study of crystals and the energies held within a gem’s facets grants you special arcane crystal ward spells, which are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool when you make your next daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the (action: Refocus) activity to research and memorize the properties of gems." };
            yield return new TextBlock { Id = Guid.Parse("51fedccd-192f-4116-b8a1-fc46b5174bb1"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. You gain the (spell: electrified crystal ward) focus spell, and you are trained in arcane spell attack rolls and spell DCs. Your spellcasting ability is Intelligence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c24acc2a-0ac5-410a-a067-8acba7176717"), Feats.Instances.CrystalKeeperDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fee1c373-9ad1-4d08-b421-3a4c2af81343"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
