using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class StudiousSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("71fb22e7-86d9-4275-8c09-a75aa91c8a71");

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
            yield return new TextBlock { Id = Guid.Parse("f4c4d7e4-e1eb-41cf-889f-6e5d5bd24605"), Type = TextBlockType.Text, Text = "Your hybrid study grants you additional spells that can enhance your power in combat. You gain two special 2nd-level studious spell slots, which can be used to prepare spider climb, true strike, water breathing, and an additional spell depending on your hybrid study. You add any spells from this class feature to your spellbook. At 11th level, the extra slots increase to 3rd level and you add haste and an additional spell depending on your hybrid study. At 13th level, the extra slots increase to 4th level and you add fly and an additional spell depending on your hybrid study." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Effects are added by the individual hybrid studies.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ea40370-ecba-4c0e-814c-a843a993f57a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 41
            };
        }
    }
}
