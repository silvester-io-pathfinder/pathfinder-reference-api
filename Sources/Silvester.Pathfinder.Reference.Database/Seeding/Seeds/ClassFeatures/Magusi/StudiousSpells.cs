using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class StudiousSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Studious Spells", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your hybrid study grants you additional spells that can enhance your power in combat. You gain two special 2nd-level studious spell slots, which can be used to prepare spider climb, true strike, water breathing, and an additional spell depending on your hybrid study. You add any spells from this class feature to your spellbook. At 11th level, the extra slots increase to 3rd level and you add haste and an additional spell depending on your hybrid study. At 13th level, the extra slots increase to 4th level and you add fly and an additional spell depending on your hybrid study." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //Effects are added by the individual hybrid studies.
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 41
            };
        }
    }
}
