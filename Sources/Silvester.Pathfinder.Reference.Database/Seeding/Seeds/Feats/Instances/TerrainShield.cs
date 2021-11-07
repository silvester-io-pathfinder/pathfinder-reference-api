using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainShield : Template
    {
        public static readonly Guid ID = Guid.Parse("09fcf4f3-88ea-4e2a-9539-79d15344e743");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Shield",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A Strike would damage you.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4a50696-9d02-4f1f-bb7d-f014b0100066"), Type = TextBlockType.Text, Text = "You’re so attuned to the land that it rises up to protect you from a potentially fatal blow in a seeming coincidence. For instance, a branch suddenly falls from a nearby tree to take the brunt of a sword swing or a surprising change of current disrupts an enemy’s attack. You gain resistance to physical damage equal to double your level against the triggering (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c67607d-ffcd-44bd-940f-59708520a633"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("bd87e9a5-9297-494d-814c-186eff236085"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfd849f6-5cd6-4acb-afb5-e15c975dbceb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
